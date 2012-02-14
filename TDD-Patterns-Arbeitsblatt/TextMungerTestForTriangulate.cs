using NUnit.Framework;

namespace TDD_Patterns_Arbeitsblatt
{
    public class TextMungerTestForTriangulate {

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
                return text.Substring(0, 1)
                     + text.Substring(2, 1)
                     + text.Substring(1, 1)
                     + text.Substring(3, 1);
		    return text;
	    }
    }
}
