﻿using Microsoft.AspNetCore.Components;
using Skclusive.Core.Component;
using Skclusive.Material.Core;

namespace Skclusive.Material.Table
{
    public class TableBodyComponent : MaterialComponent
    {
        public TableBodyComponent() : base("TableBody")
        {
        }

        [Parameter]
        public string Component { set; get; } = "tbody";

        protected ITableContentContext TableContentContext => new TableContentContextBuilder()
            .WithPortion(Portion.Body)
            .Build();
    }
}
