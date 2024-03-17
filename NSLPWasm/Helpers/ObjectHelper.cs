using System.Reflection;

namespace NSLPWasm.Helpers
{
    public class ObjectHelper<T>
    {
        public static T SetNullStringToEmptyStringProperties(T obj)
        {
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                if (type == typeof(string))
                {
                    if (prop.GetValue(obj, null) == null)
                        prop.SetValue(obj, string.Empty);
                }

                if (type == typeof(int))
                {
                    if (prop.GetValue(obj, null) == null)
                        prop.SetValue(obj, 0);
                }
            }

            return obj;
        }

        public static T SetWhiteSpaceStringToEmptyStringProperties(T obj)
        {
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                if (type == typeof(string))
                {
                    if (prop.GetValue(obj, null) == null)
                        prop.SetValue(obj, string.Empty);

                    else
                    {
                        if (string.IsNullOrWhiteSpace(prop.GetValue(obj, null).ToString()))
                            prop.SetValue(obj, string.Empty);
                    }

                }
            }

            return obj;
        }

    }
}
