﻿using Orchard.ContentManagement.Records;

namespace Orchard.Widgets.Models {
    public class WidgetPartRecord : ContentPartRecord {
        public virtual string Title { get; set; }
        public virtual string Position { get; set; }
        public virtual string Zone { get; set; }
    }
}
