using System.ComponentModel.DataAnnotations.Schema;

namespace CalisthenicsSHOP.Models
{
    public enum ProductCategoryEnum
    {
        Equipment,
        Accessories,
        Cloth,
        Shoes,
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName="decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ProductCategoryEnum Category { get; set; }

        public static bool operator == (Product prod1, Product prod2)
        {
            if(prod1 is null)
            {
                if(prod2 is null)
                {
                    return true;
                }

                return false;
            }

            return prod1.Equals(prod2);
        }
  

        public static bool operator != (Product prod1, Product prod2) => !(prod1 == prod2);

        public bool Equals(Product obj)
        {
            if(obj is null)
            {
                return false;
            }
            if(Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            if(this.GetType() != obj.GetType())
            {
                return false;
            }

            return (Name == obj.Name
                 && Price == obj.Price
                 && Description == obj.Description
                 && Category == obj.Category);
        }

        public override bool Equals(object obj) => this.Equals(obj as Product);

        public override int GetHashCode()
        {
            return (Name, Category).GetHashCode();
        }

        public bool IsValid()
        {
            return !(string.IsNullOrEmpty(Name) && Price == null);
        }
    }
}
