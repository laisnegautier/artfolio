using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace artfolio.ValidationAttributes
{
    public static class FormFileExtensions
    {
        public const int FileMinimumBytes = 512;

        public static bool IsImage(this IFormFile postedFile, out string error)
        {
            error = null;

            //  Check the image extension
            string ext = Path.GetExtension(postedFile.FileName).ToLower();
            List<string> extensions = new List<string> { ".jpg", ".png", ".gif", ".jpeg" };
            if (!extensions.Contains(ext))
            {
                error = "Only .jpg, .png, .gif and .jpeg files are accepted.";
                return false;
            }

            //  Check the image mime types
            string contentType = postedFile.ContentType.ToLower();
            List<string> mime = new List<string> { "image/jpg", "image/jpeg", "image/pjpeg", "image/gif", "image/x-png", "image/png" };
            if (!mime.Contains(contentType))
            {
                error = "The extension does not match the content-type of the uploaded file.";
                return false;
            }
            
            //  Attempt to read the file and check the first bytes
            if (!IsReadableAndNotAScript(postedFile)) 
            {
                error = "The uploaded file is not readeable. Please retry.";
                return false;
            }

            //  Try to instantiate new Bitmap, if .NET will throw exception
            //  we can assume that it's not a valid image
            try
            {
                using (var bitmap = new System.Drawing.Bitmap(postedFile.OpenReadStream()))
                {
                }
            }
            catch (Exception)
            {
                error = "The uploaded file can't be opened.";
                return false;
            }
            finally
            {
                postedFile.OpenReadStream().Position = 0;
            }

            return true;
        }

        public static bool IsAudio(this IFormFile postedFile, out string error)
        {
            error = null;

            //  Check the audio extension
            string ext = Path.GetExtension(postedFile.FileName).ToLower();
            List<string> extensions = new List<string> { ".mid", ".midi", ".mp3", ".aac", ".3gpp", ".3gpp2", ".wav", ".oga", ".opus", ".weba" };
            if (!extensions.Contains(ext))
            {
                error = "Only .mid, .midi, .mp3, .aac, .3gpp, .3gpp2, .wav, .oga, .opus, .weba files are accepted.";
                return false;
            }

            //  Check the audio mime types
            string contentType = postedFile.ContentType.ToLower();
            List<string> mime = new List<string> { "audio/midi", "audio/x-midi", "audio/mpeg", "audio/aac", "audio/3gpp", "audio/3gpp2", "audio/ogg", "audio/opus", "audio/wav", "audio/webm" };
            if (!mime.Contains(contentType))
            {
                error = "The extension does not match the content-type of the uploaded file.";
                return false;
            }

            //  Attempt to read the file and check the first bytes
            if (!IsReadableAndNotAScript(postedFile))
            {
                error = "The uploaded file is not readeable. Please retry.";
                return false;
            }

            return true;
        }

        public static bool IsPDF(this IFormFile postedFile, out string error)
        {
            error = null;

            // Check the pdf extension
            string ext = Path.GetExtension(postedFile.FileName).ToLower();
            List<string> extensions = new List<string> { ".pdf" };
            if (!extensions.Contains(ext))
            {
                error = "Only .pdf files are accepted.";
                return false;
            }

            //  Check the pdf mime types
            string contentType = postedFile.ContentType.ToLower();
            List<string> mime = new List<string> { "audio/pdf" };
            if (!mime.Contains(contentType))
            {
                error = "The extension does not match the content-type of the uploaded file.";
                return false;
            }

            // Attempt to read the file and check the first bytes
            if (!IsReadableAndNotAScript(postedFile))
            {
                error = "The uploaded file is not readeable. Please retry.";
                return false;
            }

            return true;
        }

        public static bool IsReadableAndNotAScript(IFormFile postedFile)
        {
            try
            {
                if (!postedFile.OpenReadStream().CanRead) return false;

                // check whether the image size exceeding the limit or not
                if (postedFile.Length < FileMinimumBytes) return false;

                // check if it is not a script
                byte[] buffer = new byte[FileMinimumBytes];
                postedFile.OpenReadStream().Read(buffer, 0, FileMinimumBytes);
                string content = System.Text.Encoding.UTF8.GetString(buffer);
                if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                    RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
