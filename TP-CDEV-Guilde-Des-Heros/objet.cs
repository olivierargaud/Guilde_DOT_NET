//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_CDEV_Guilde_Des_Heros
{
    using System;
    using System.Collections.Generic;
    
    public partial class objet
    {
        public int obj_id { get; set; }
        public string obj_nom { get; set; }
        public Nullable<int> obj_level { get; set; }
        public Nullable<int> obj_quantite { get; set; }
        public string obj_description { get; set; }
        public Nullable<double> obj_prix { get; set; }
        public Nullable<int> obj_hero_id { get; set; }
    
        public virtual hero hero { get; set; }
    }
}
