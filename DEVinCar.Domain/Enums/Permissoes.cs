using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DEVinCar.Domain.Enums
{
    public enum Permissoes
    {
        [XmlEnumAttribute("G")]
        [Display(Name = "Gerente")]
        Gerente,
        [XmlEnumAttribute("V")]
        [Display(Name = "Vendedor")]
        Vendedor,
        [XmlEnumAttribute("C")]
        [Display(Name = "Comprador")]
        Comprador
    }

    public static class EnumExtensions
    {
        public static string GetName(this Enum enumValue)
        {
            string? displayName;
            displayName = enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              ?.GetCustomAttribute<DisplayAttribute>()
              ?.GetName();

            if (String.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }
    }

}