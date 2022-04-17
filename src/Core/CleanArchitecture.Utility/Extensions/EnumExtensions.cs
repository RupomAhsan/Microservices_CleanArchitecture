using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using CleanArchitecture.Utility.Extensions;

namespace CleanArchitecture.Utility.Extensions;

public static class EnumExtensions
{
    public static List<T> ToList<T>(this T value) where T : Enum
    {
        return value.ToString().Split(',').Select(flag => (T)Enum.Parse(typeof(T), flag)).ToList();
    }

    public static string GetDisplayName<T>(this T enumValue) where T : Enum
    {
        return enumValue.GetType()
                        .GetMember(enumValue.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()?
                        .GetName() ?? enumValue.ToString();
    }
    public static string GetValue<T>(this T enumValue) where T : Enum
    {
        FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());

        DescriptionAttribute[] attributes = (DescriptionAttribute[]) field
                          .GetCustomAttributes(typeof(DescriptionAttribute),false);

        if(attributes!=null && attributes.Length>0)
            return attributes[1].Description;
        else
            return enumValue.ToString();
    }
}
