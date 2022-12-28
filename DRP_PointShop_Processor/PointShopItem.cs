using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace DRP_PointShop_Processor
{
    internal class PointShopItem
    {
        private readonly string _itemName, _itemModel, _itemDesc, _itemFocus, _itemClassName, _itemData;


        public PointShopItem(string itemName, string itemDesc, string itemModel, string itemFocus, string itemData)
        { 
            _itemName = Regex.Replace(itemName, "\"", ""); ;
            _itemDesc = Regex.Replace(itemDesc, "\"", "");
            _itemFocus = Regex.Replace(itemFocus, "\"", ""); ;
            _itemModel = Regex.Replace(itemModel, "\"", ""); ;

            _itemClassName = Regex.Replace(_itemName, " ", "_").ToLower();
            _itemData = Regex.Replace(itemData, "SWEP", "ITEM");

        }
        public bool createFile(string outputPath)
        {
            try
            {
                string outputString = "ITEM = {}\r\n\r\nITEM.ClassName = \"" + _itemClassName + "\"\r\nITEM.Name = \""+ _itemName +"\"\r\nITEM.Description = \"" + _itemDesc + "\"\r\nITEM.Model = \"" + _itemModel + "\"\r\n\r\nITEM.PointsCost = 2500\r\nITEM.PremiumPointsCost = 0\r\n\r\nITEM.AddToInventory = true\r\nITEM.FocusPart = \""+ _itemFocus +"\"\r\nITEM.Adjustable = true\r\n\r\n"+ _itemData +"\r\nITEM.PACData = nil\r\n\r\nSH_POINTSHOP:RegisterItem(ITEM, \"accessories\")\r\n"; // Sorry about this long ass line
                File.WriteAllText(outputPath, outputString);
            } catch 
            {
                return false;
            }

            return true;
        }
    }
}
