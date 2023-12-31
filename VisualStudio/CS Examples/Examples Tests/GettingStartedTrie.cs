﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiftyOne.Example.Illustration.CSharp.GettingStartedTrie;

namespace Examples_Tests
{
    [TestClass]
    public class GettingStartedTrie
    {
        [TestMethod]
        [TestCategory("CSharpAPIExample"), TestCategory("Lite")]
        public void LiteExamples_Getting_Started_Trie()
        {
            Program.Run(Constants.LITE_TRIE_V32);
        }
        [TestMethod]
        [TestCategory("CSharpAPIExample"), TestCategory("Premium")]
        public void PremiumExamples_Getting_Started_Trie()
        {
            Program.Run(Constants.PREMIUM_TRIE_V32);
        }
        [TestMethod]
        [TestCategory("CSharpAPIExample"), TestCategory("Enterprise")]
        public void EnterpriseExamples_Getting_Started_Trie()
        {
            Program.Run(Constants.ENTERPRISE_TRIE_V32);
        }
    }
}
