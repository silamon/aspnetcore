// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcSandbox;

    [Flags]
    public enum Fruit
    {
        Love = 1,
        Joy = 2,
        Peace = 4,
        Patience = 8,
        Kindness = 16,
        Goodness = 32,
        Faithfulness = 64,
        Gentleness = 128,
        SelfControl = 256
    }

public class PagesHome : PageModel
{
    public string Name { get; private set; } = "World";

    [BindProperty]
    public Fruit MyFruit { get; set; }
}
