//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Current_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Current_order()
        {
            this.Addto = new HashSet<Addto>();
        }
    
        public long Order_id { get; set; }
        public long Userid { get; set; }
        public long OrderManagerid { get; set; }
        public long Value { get; set; }
        public System.DateTime Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Addto> Addto { get; set; }
        public virtual Order_Manager Order_Manager { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
