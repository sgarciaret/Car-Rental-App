//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypesOfCars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypesOfCars()
        {
            this.CarRentalRecord = new HashSet<CarRentalRecord>();
        }
    
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string LicensePlateNumber { get; set; }
        public Nullable<int> Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarRentalRecord> CarRentalRecord { get; set; }
    }
}
