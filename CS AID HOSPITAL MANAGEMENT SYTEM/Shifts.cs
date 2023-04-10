using System.ComponentModel;

namespace CS_Aid_Hospital_Management_System
{
    public enum Shifts
    {

        [Description("Monday to Friday, 7AM to 7PM")]
        MF77A,

        [Description("Monday to Friday, 1PM to 1AM")]
        MF11,

        [Description("Monday to Friday, 7PM to 7AM")]
        MF77P,

        [Description("Monday to Friday, 7AM to 3PM")]
        MF73,

        [Description("Monday to Friday, 3PM to 11PM")]
        MF311,

        [Description("Monday to Friday, 11PM to 7AM")]
        MF117,

        [Description("Tuesday to Saturday, 7AM to 7PM")]
        TS77A,

        [Description("Tuesday to Saturday, 1PM to 1AM")]
        TS11,

        [Description("Tuesday to Saturday, 7PM to 7AM")]
        TS77P,

        [Description("Tuesday to Saturday, 7AM to 3PM")]
        TS73,

        [Description("Tuesday to Saturday, 3PM to 11PM")]
        TS311,

        [Description("Tuesday to Saturday, 11PM to 7AM")]
        TS117
    };

}

/*
public static string GetDescriptionFromEnum(Enum value)
{
     DescriptionAttribute attribute = value.GetType()
     .GetField(value.ToString())
     .GetCustomAttributes(typeof(DescriptionAttribute), false)
     .SingleOrDefault() as DescriptionAttribute;
     return attribute == null ? value.ToString() : attribute.Description;
}

public static string GetDescriptionFromEnum(Enum value)
{
      FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
      DescriptionAttribute[] attributes =
        (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
      return attributes == null && attributes.Length == 0 ? value.ToString() : attributes[0].Description;
}
*/

