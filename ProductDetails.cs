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
        public required string Name { get; set; }
        public required string Price { get; set; }
        public required IWebElement Link { get; set; }
    }
}