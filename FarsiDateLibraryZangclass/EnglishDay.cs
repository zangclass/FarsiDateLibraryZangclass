using System.ComponentModel.DataAnnotations;

namespace FarsiDateLibraryZangclass
{
    public enum EnglishDay
    {
        [Display(Name = "شنبه")]
        Saturday,
        [Display(Name = "یکشنبه")]
        Sunday,
        [Display(Name = "دوشنبه")]
        Monday,
        [Display(Name = "سه شنبه")]
        Tuesday,
        [Display(Name = "چهار شنبه")]
        Wednesday,
        [Display(Name = "پنج شنبه")]
        Thursday,
        [Display(Name = "جمعه")]
        Friday
    }
}
