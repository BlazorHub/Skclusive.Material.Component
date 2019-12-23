﻿using Microsoft.AspNetCore.Components;
using Skclusive.Material.Core;
using System.Collections.Generic;

namespace Skclusive.Material.Table
{
    public class TableRowComponent : MaterialComponent
    {
        public TableRowComponent() : base("TableRow")
        {
        }

        [Parameter]
        public string Component { set; get; } = "tr";

        [Parameter]
        public bool Selected { set; get; } = false;

        [Parameter]
        public bool Hover { set; get; } = false;

        [CascadingParameter]
        public ITableContentContext ContentContext { set; get; }

        protected override IEnumerable<string> Classes
        {
            get
            {
                foreach (var item in base.Classes)
                    yield return item;

                if (ContentContext?.Portion != null)
                    yield return $"{ContentContext?.Portion}";

                if (Hover)
                    yield return nameof(Hover);

                if (Selected)
                    yield return nameof(Selected);
            }
        }
    }
}
