﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);

        StringBuilder stringBuilder = new StringBuilder();
        MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        stringBuilder.AppendLine($"All Private Methods of Class: {investigatedClass}");
        stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in classMethods)
        {
            stringBuilder.AppendLine(method.Name);
        }

        return stringBuilder.ToString().Trim();
    }
}