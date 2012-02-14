using NUnit.Framework;

namespace TDD_Patterns_Arbeitsblatt
{
    public class TextMungerTestForFakeItTillYouMakeIt {

	    [Test]
	    public void LaesstWortBisDreiZeichenUnveraendert() {
		    Assert.That(Verdrehe("abc"), Is.EqualTo("abc"));
	    }

	    [Test]
	    public void DrehtZeichenInDerMitteUmFuerWortAusVierZeichen() {
		    Assert.That(Verdrehe("abcd"), Is.EqualTo("acbd"));
	    }

	    private string Verdrehe(string text) {
            if ("abcd".Equals(text))
                return "acbd";
		    return text;
	    }
    }
}
