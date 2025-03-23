using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAutomationEngineerAssignment
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public IWebElement Link { get; set; }
    }
}
