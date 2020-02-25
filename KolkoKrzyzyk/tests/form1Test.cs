using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using KolkoKrzyzyk;
using NUnit.Framework.Constraints;


namespace KolkoKrzyzyk.tests
{
    [TestFixture]
    class form1Test
    {
        [Test]
        public void IsButtonNotNull_ShouldReturnTrue()
        {
            Button button = new Button();
            button.Text = "";
            Assert.False(KolkoIKrzyzyk.isButtonNotNull(button));
        }

        [Test]
        public void IsButtonNotNull_ShouldReturnFalse()
        {
            Button button = new Button();
            button.Text = "value";
            Assert.True(KolkoIKrzyzyk.isButtonNotNull(button));

        }

        [Test]
        public void IsWinningButton1_2_3_ShouldReturnTrue()
        {
            Button button1 = new Button();
            button1.Text = "X";
            Button button2 = new Button();
            button2.Text = "X";
            Button button3 = new Button();
            button3.Text = "X";
            Assert.True(KolkoIKrzyzyk.isWinningMove(button1, button2,button3));
        }

        [Test]
        public void IsWinningButton1_2_4_ShouldNotReturnTrue()
        {
            Button button1 = new Button();
            button1.Text = "X";
            Button button2 = new Button();
            button2.Text = "X";
            Button button3 = new Button();
            button3.Text = "Y";
            Assert.False(KolkoIKrzyzyk.isWinningMove(button1, button2, button3));
        }

        [Test]
        public void IsWinningButton1_5_9_ShouldNotReturnTrue()
        {
            Button button1 = new Button();
            button1.Text = "X";
            Button button2 = new Button();
            button2.Text = "X";
            Button button3 = new Button();
            button3.Text = "X";
            Assert.True(KolkoIKrzyzyk.isWinningMove(button1, button2, button3));
        }
    }
}
