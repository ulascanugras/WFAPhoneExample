using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WFAPhoneAbstractionExample.Abstract;
using WFAPhoneAbstractionExample.Properties;

namespace WFAPhoneAbstractionExample.Concrete
{
    public class Nokia : BasePhone, IPlaySound
    {
        private SoundPlayer soundPlayer;
        public Nokia()
        {
            soundPlayer = new SoundPlayer(Resources.nokia);
        }
        public void PlaySound()
        {
            soundPlayer.Play();
            Thread.Sleep(2000);
            StopSound();
        }

        public void StopSound()
        {
            soundPlayer.Stop();
        }
    }
}
