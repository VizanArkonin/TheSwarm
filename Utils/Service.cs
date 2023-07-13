using System.Reflection;

namespace TheSwarm.Utils.Service;

public static class AttributeHelper {
    public static bool TypeContainsAttribute(Type type, Type attribute) {
        return type.GetCustomAttribute(attribute) != null;
    }
}