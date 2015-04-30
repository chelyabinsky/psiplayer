using System;
using System.Windows.Forms;
using libZPlay;

namespace RadioPlayer
{
	class Player
	{
		Timer playerTimer = new Timer();
		public ZPlay player2 = new ZPlay();
		private Form1 frm1;
        private int[] FreqPoint;
		

		public Player(Form1 frm)
		{
			frm1 = frm;
			playerTimer.Tick += Update;
			playerTimer.Start();
			playerTimer.Interval = 100;
            FreqPoint = new int[9] { 80, 200, 400, 700, 1500, 3000, 6000, 9000, 12000 };
            player2.SetEqualizerPoints(ref FreqPoint, 9);
            
		}

		private void someMethod()
		{
		}

		private void Update(object sender, EventArgs e)
		{
			TimeSpan ts, ts2;
			TStreamTime pos = new TStreamTime();
			TStreamInfo info = new TStreamInfo();
			TStreamTime time = new TStreamTime();

			player2.GetPosition(ref pos);
			player2.GetStreamInfo(ref info);
			time = info.Length;
			ts = TimeSpan.FromSeconds(Convert.ToDouble(pos.sec.ToString()));
			ts2 = TimeSpan.FromSeconds(Convert.ToDouble(time.sec.ToString()));

			if (Convert.ToInt32(time.sec) > 0)
			{
				if (Convert.ToInt32(time.sec) - Convert.ToInt32(pos.sec) <= 0)
				{
					frm1.Invoke((MethodInvoker)delegate
					{
						frm1.Forward();
					});
				}
				Form1.ChangeNameLabel(ts + "/" + ts2);
				Form1.ChangePositionBar(Convert.ToInt32(pos.sec) * 100 / Convert.ToInt32(time.sec));
			}
		}

		public void PlayMusicFromURL(AudioFile audio)
		{
			player2.OpenFile(audio.Url, TStreamFormat.sfAutodetect);
			player2.StartPlayback();
		}

		public void SetPlayerVolume(int volume)
		{
			player2.SetMasterVolume(volume, volume);
		}

		public void SetPlayerPosition(int p)
		{
			TStreamStatus status = new TStreamStatus();
			if (status.fPlay)
			{
				player2.PausePlayback();
			}
			TStreamTime newpos = new TStreamTime();
			TStreamInfo info = new TStreamInfo();
			TStreamTime time = new TStreamTime();

			player2.GetStreamInfo(ref info);
			time = info.Length;

			newpos.sec = Convert.ToUInt32(p * time.sec / 100);
			player2.Seek(TTimeFormat.tfSecond, ref newpos, TSeekMethod.smFromBeginning);
			player2.StartPlayback();
		}

		public void SetPoints(int point, int value)
		{
			player2.SetEqualizerBandGain(point, value);
		}

		public void Pause()
		{
			player2.PausePlayback();
		}

		public void Play()
		{
			player2.StartPlayback();
		}

		public void Stop()
		{
			player2.StopPlayback();
		}
	}
}
