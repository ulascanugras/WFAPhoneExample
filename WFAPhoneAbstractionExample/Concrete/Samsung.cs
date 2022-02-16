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
    public class Samsung : BasePhone, IPlaySound
    {
        private SoundPlayer soundPlayer;
        public Samsung()
        {
            soundPlayer = new SoundPlayer(Resources.samsung);
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
