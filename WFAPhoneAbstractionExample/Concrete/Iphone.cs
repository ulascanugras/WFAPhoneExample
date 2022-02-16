using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WFAPhoneAbstractionExample.Abstract;
using WFAPhoneAbstractionExample.Properties;

namespace WFAPhoneAbstractionExample.Concrete
{
    public class Iphone : BasePhone, IPlaySound
    {
        private SoundPlayer soundPlayer;
        public Iphone()
        {
            soundPlayer = new SoundPlayer(Resources.iphone);
        }
        public void PlaySound()
        {
            soundPlayer.Play();
        }

        public void StopSound()
        {
            soundPlayer.Stop();
        }
    }
}
