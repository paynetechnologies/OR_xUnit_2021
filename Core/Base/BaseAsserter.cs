using Shouldly;

namespace Core.Base
{
    public abstract partial class BasePage
    {
        public void TitleShouldNotBe(string expected) => Browser.Title.ShouldNotBeEmpty();
        public void TitleShouldBe(string expected) => Browser.Title.ShouldBe(expected);
    }
}
