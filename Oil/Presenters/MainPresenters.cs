using Oil.Data;
using Oil.Model;
using Oil.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil.Presenters
{
    public class MainPresenters
    {
        public List<OilClass> oils = new List<OilClass>()
        {
            new OilClass()
            {
                Name="AI92",
                Price=1
            },
            new OilClass()
            {
                Name="AI95",
                Price=2
            },
            new OilClass()
            {
                Name="AI98",
                Price=2.3
            },
            new OilClass()
            {
                Name="Diesel",
                Price=0.8
            }
        };

        private readonly IMainView _view;
        private readonly OilContext _db;

        public MainPresenters(IMainView view)
        {
            _view = view;
            _db = new OilContext();
            LoadAllData();
            _view.LoadMain += ViewLoadMain;
            _view.SelectionChange += ViewSelectionChange;
            _view.MoneyChange += ViewMoneyChange;
            _view.LiterChange += ViewLiterChange;

        }

        private void ViewMoneyChange(object sender, EventArgs e)
        {
            if (_view.MoneyText != String.Empty)
            {
                _view.TotalAmountText = decimal.Parse(_view.MoneyText).ToString();
            }
            else
            {
                _view.TotalAmountText = "0.00";
            }
        }

        private void ViewLiterChange(object sender, EventArgs e)
        {
            if (_view.LiterText != String.Empty)
            {
                _view.TotalAmountText = (decimal.Parse(_view.LiterText) * decimal.Parse(_view.PriceText)).ToString();
            }
            else
            {
                _view.TotalAmountText = "0.00";
            }
        }

        private void ViewLoadMain(object sender, EventArgs e)
        {
            var myoils = _db.Oils.ToList();
            _view.Oils = myoils;
        }

        private void ViewSelectionChange(object sender, EventArgs e)
        {
            var oil = _view.SelectedOil;
            _view.PriceText = oil.Price.ToString();
        }

        private void LoadAllData()
        {
            if (!_db.Oils.Any())
            {
                _db.Oils.AddRange(oils);
                _db.SaveChanges();
            }
        }
    }
}
