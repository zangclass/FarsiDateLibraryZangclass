using System.ComponentModel.DataAnnotations;

namespace FarsiDateLibraryZangclass
{
    public enum MonthFarsi
    {
        [Display(Name ="قروردین")]
        Farvardin,
        [Display(Name = "اردیبهست")]
        Ordibehesht,
        [Display(Name = "خرداد")]
        Khordad,
        [Display(Name = "تیر")]
        Tir,
        [Display(Name = "مرداد")]
        Mordad,
        [Display(Name = "شهریور")]
        Shahrivar,
        [Display(Name = "مهر")]
        Mehr,
        [Display(Name = "آبان")]
        Aban,
        [Display(Name = "آذر")]
        Azar,
        [Display(Name = "دی")]
        Dey,
        [Display(Name = "بهمن")]
        Bahman,
        [Display(Name = "اسفند")]
        Esfand
    }
}
