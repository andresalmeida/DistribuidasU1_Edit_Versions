﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;

    public partial class SecurityLog
    {
        public int LogID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string EventType { get; set; }
        public Nullable<System.DateTime> EventTime { get; set; }
        public string IPAddress { get; set; }
        public string Description { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
