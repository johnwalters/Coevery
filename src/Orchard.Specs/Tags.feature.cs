﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Tags")]
    public partial class TagsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Tags.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tags", "  In order to add tags to my content\r\n  As an author\r\n  I want to create, publish" +
                    " and edit pages", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can add a tag to a new Page")]
        public virtual void ICanAddATagToANewPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can add a tag to a new Page", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have installed Orchard");
#line 8
    testRunner.When("I go to \"admin/contents/create/page\"");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "Routable.Title",
                        "Super Duper"});
            table1.AddRow(new string[] {
                        "Body.Text",
                        "This is super."});
            table1.AddRow(new string[] {
                        "Tags.Tags",
                        "Foo, Bar"});
#line 9
        testRunner.And("I fill in", ((string)(null)), table1);
#line 14
        testRunner.And("I hit \"Publish Now\"");
#line 15
        testRunner.And("I go to \"super-duper\"");
#line 16
    testRunner.Then("I should see \"<h1[^>]*>.*?Super Duper.*?</h1>\"");
#line 17
        testRunner.And("I should see \"Foo\"");
#line 18
        testRunner.And("I should see \"Bar\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can\'t add a tag with disallowed chars to a new Page")]
        public virtual void ICanTAddATagWithDisallowedCharsToANewPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can\'t add a tag with disallowed chars to a new Page", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
    testRunner.Given("I have installed Orchard");
#line 22
    testRunner.When("I go to \"admin/contents/create/page\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "Routable.Title",
                        "Super Duper"});
            table2.AddRow(new string[] {
                        "Body.Text",
                        "This is super."});
            table2.AddRow(new string[] {
                        "Tags.Tags",
                        "Foo, I <3 Orchard"});
#line 23
        testRunner.And("I fill in", ((string)(null)), table2);
#line 28
        testRunner.And("I hit \"Publish Now\"");
#line 29
        testRunner.And("I go to \"super-duper\"");
#line 30
    testRunner.Then("I should see \"<h1[^>]*>.*?Super Duper.*?</h1>\"");
#line 31
        testRunner.And("I should see \"<a[^>]*>Foo</a>\"");
#line 32
        testRunner.And("I should not see \"<a[^>]*>I &lt;3 Orchard</a>\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
