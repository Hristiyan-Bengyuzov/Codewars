using System;
using System.Collections.Generic;
using System.Linq;

public class DirReduction
{
    public static string[] dirReduc(String[] arr)
    {
        var opposite = new Dictionary<string, string>
        {
            {"NORTH", "SOUTH"},
            {"EAST", "WEST"},
            {"SOUTH", "NORTH"},
            {"WEST", "EAST"}
        };

        var stack = new Stack<string>();

        foreach (var dir in arr)
        {
            if (stack.Any() && opposite[dir] == stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(dir);
            }
        }

        return stack.Reverse().ToArray();
    }
}