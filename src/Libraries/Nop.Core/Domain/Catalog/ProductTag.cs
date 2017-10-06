using System.Collections.Generic;
using Nop.Core.Domain.Localization;

namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// Represents a product tag
    /// </summary>
    public partial class ProductTag : BaseEntity, ILocalizedEntity
    {
        private ICollection<Product_ProductTag_Mappng> _products;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the products
        /// </summary>
        public virtual ICollection<Product_ProductTag_Mappng> Products
        {
            get { return _products ?? (_products = new List<Product_ProductTag_Mappng>()); }
            protected set { _products = value; }
        }
    }
}
