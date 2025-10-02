using System.ComponentModel;

namespace Grocery.Core.Models
{
    public class GroceryListItem : Model, INotifyPropertyChanged
    {
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }

        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                if (_amount == value) return;
                _amount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Amount)));
            }
        }

        public Product Product { get; set; } = new(0, "None", 0);

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            _amount = amount; // gebruik backing field
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
