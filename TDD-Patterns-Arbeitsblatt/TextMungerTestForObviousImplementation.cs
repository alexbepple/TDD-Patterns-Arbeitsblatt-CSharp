using NUnit.Framework;

namespace TDD_Patterns_Arbeitsblatt
{
    public class TextMungerTestForObviousImplementation {

	    [Test]
	    public void LaesstWortBisDreiZeichenUnveraendert() {
		    Assert.That(Verdrehe("abc"), Is.EqualTo("abc"));
	    }

	    [Test]
        [Ignore]
	    public void DrehtZeichenInDerMitteUmFuerWortAusVierZeichen() {
		    Assert.That(Verdrehe("abcd"), Is.EqualTo("acbd"));
	    }

	    private string Verdrehe(string text) {
		    return text;
	    }
    }
}
