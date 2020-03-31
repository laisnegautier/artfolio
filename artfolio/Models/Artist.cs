using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace artfolio.Models
{
    /// <summary>
    /// An artist is the publicly visible part of a user
    /// </summary>
    public class Artist : IdentityUser
    {
        //public int ArtistId { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Last name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Characters are not allowed.")]
        public string Lastname { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "First name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Characters are not allowed.")]
        public string Firstname { get; set; }

        [PersonalData]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [PersonalData]
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Nationnality")]
        public Nationality Nationality { get; set; }

        [Required]
        [PersonalData]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [DataType(DataType.ImageUrl)]
        public string PhotoFilePath { get; set; }
        
        [Required]
        [Display(Name = "Keep your profile public")]
        public bool IsPubliclyVisible { get; set; }

               
        public virtual ICollection<Artwork> Artworks { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }


        public virtual ICollection<FollowRelation> Following { get; set; }
        public virtual ICollection<FollowRelation> FollowedBy { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum Nationality
    {
        Afghan,
        Albanian,
        Algerian,
        American,
        Andorran,
        Angolan,
        Antiguans,
        Argentinean,
        Armenian,
        Australian,
        Austrian,
        Azerbaijani,
        Bahamian,
        Bahraini,
        Bangladeshi,
        Barbadian,
        Barbudans,
        Batswana,
        Belarusian,
        Belgian,
        Belizean,
        Beninese,
        Bhutanese,
        Bolivian,
        Bosnian,
        Brazilian,
        British,
        Bruneian,
        Bulgarian,
        Burkinabe,
        Burmese,
        Burundian,
        Cambodian,
        Cameroonian,
        Canadian,
        [Display(Name = "Cape Verdean")]
        CapeVerdean,
        [Display(Name = "Central African")]
        CentralAfrican,
        Chadian,
        Chilean,
        Chinese,
        Colombian,
        Comoran,
        Congolese,
        [Display(Name = "Costa Rican")]
        CostaRican,
        Croatian,
        Cuban,
        Cypriot,
        Czech,
        Danish,
        Djibouti,
        Dominican,
        Dutch,
        [Display(Name = "East Timorese")]
        EastTimorese,
        Ecuadorean,
        Egyptian,
        Emirian,
        [Display(Name = "Equatorial Guinean")]
        EquatorialGuinean,
        Eritrean,
        Estonian,
        Ethiopian,
        Fijian,
        Filipino,
        Finnish,
        French,
        Gabonese,
        Gambian,
        Georgian,
        German,
        Ghanaian,
        Greek,
        Grenadian,
        Guatemalan,
        [Display(Name = "Guinea-Bissauan")]
        GuineaBissauan,
        Guinean,
        Guyanese,
        Haitian,
        Herzegovinian,
        Honduran,
        Hungarian,
        [Display(Name = "I-Kiribati")]
        IKiribati,
        Icelander,
        Indian,
        Indonesian,
        Iranian,
        Iraqi,
        Irish,
        Israeli,
        Italian,
        Ivorian,
        Jamaican,
        Japanese,
        Jordanian,
        Kazakhstani,
        Kenyan,
        [Display(Name = "Kittian and Nevisian")]
        KittianAndNevisian,
        Kuwaiti,
        Kyrgyz,
        Laotian,
        Latvian,
        Lebanese,
        Liberian,
        Libyan,
        Liechtensteiner,
        Lithuanian,
        Luxembourger,
        Macedonian,
        Malagasy,
        Malawian,
        Malaysian,
        Maldivian,
        Malian,
        Maltese,
        Marshallese,
        Mauritanian,
        Mauritian,
        Mexican,
        Micronesian,
        Moldovan,
        Monacan,
        Mongolian,
        Moroccan,
        Mosotho,
        Motswana,
        Mozambican,
        Namibian,
        Nauruan,
        Nepalese,
        [Display(Name = "New Zealander")]
        NewZealander,
        [Display(Name = "Ni-Vanuatu")]
        NiVanuatu,
        Nicaraguan,
        Nigerian,
        Nigerien,
        [Display(Name = "North Korean")]
        NorthKorean,
        [Display(Name = "Northern Irish")]
        NorthernIrish,
        Norwegian,
        Omani,
        Pakistani,
        Palauan,
        Panamanian,
        [Display(Name = "Papua New Guinean")]
        PapuaNewGuinean,
        Paraguayan,
        Peruvian,
        Polish,
        Portuguese,
        Qatari,
        Romanian,
        Russian,
        Rwandan,
        [Display(Name = "Saint Lucian")]
        SaintLucian,
        Salvadoran,
        Samoan,
        [Display(Name = "San Marinese")]
        SanMarinese,
        [Display(Name = "Sao Tomean")]
        SaoTomean,
        Saudi,
        Scottish,
        Senegalese,
        Serbian,
        Seychellois,
        [Display(Name = "Sierra Leonean")]
        SierraLeonean,
        Singaporean,
        Slovakian,
        Slovenian,
        [Display(Name = "Solomon Islander")]
        SolomonIslander,
        Somali,
        [Display(Name = "South African")]
        SouthAfrican,
        [Display(Name = "South Korean")]
        SouthKorean,
        Spanish,
        [Display(Name = "Sri Lankan")]
        SriLankan,
        Sudanese,
        Surinamer,
        Swazi,
        Swedish,
        Swiss,
        Syrian,
        Taiwanese,
        Tajik,
        Tanzanian,
        Thai,
        Togolese,
        Tongan,
        Trinidadian,
        Tunisian,
        Turkish,
        Tuvaluan,
        Ugandan,
        Ukrainian,
        Uruguayan,
        Uzbekistani,
        Venezuelan,
        Vietnamese,
        Welsh,
        Yemenite,
        Zambian,
        Zimbabwean
    }
}
