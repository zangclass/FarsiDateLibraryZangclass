using System.ComponentModel.DataAnnotations;

namespace FarsiDateLibraryZangclass
{
    public enum FarsiDay
    {
        [Display(Name = "شنبه")]
        Shanbeh,
        [Display(Name = "یکشنبه")]
        YekShanbeh,
        [Display(Name = "دوشنبه")]
        Doshanbeh,
        [Display(Name = "سه شنبه")]
        SeShanbe,
        [Display(Name = "چهار شنبه")]
        ChaharShanbe,
        [Display(Name = "پنج شنبه")]
        PanjShanbeh,
        [Display(Name = "جمعه")]
        jomee
    }
}
