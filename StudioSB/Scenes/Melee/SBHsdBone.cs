﻿using HSDRaw.Common;

namespace StudioSB.Scenes.Melee
{
    /// <summary>
    /// A extension of the bone that will also edit an HSD_JOBJ
    /// </summary>
    public class SBHsdBone : SBBone
    {
        private HSD_JOBJ _jobj;

        public HSD_JOBJ GetJOBJ()
        {
            return _jobj;
        }

        public void SetJOBJ(HSD_JOBJ jobj)
        {
            _jobj = jobj;
        }

        public new float X
        {
            get => base.X;
            set
            {
                if(_jobj != null)
                    _jobj.TX = value;
                base.X = value;
            }
        }
        public new float Y
        {
            get => base.Y;
            set
            {
                if (_jobj != null)
                    _jobj.TY = value;
                base.Y = value;
            }
        }
        public new float Z
        {
            get => base.Z;
            set
            {
                if (_jobj != null)
                    _jobj.TZ = value;
                base.Z = value;
            }
        }


        public new float RX
        {
            get => _jobj.RX;
            set
            {
                if (_jobj != null)
                    _jobj.RX = value;
                base.RX = value;
            }
        }
        public new float RY
        {
            get => _jobj.RY;
            set
            {
                if (_jobj != null)
                    _jobj.RY = value;
                base.RY = value;
            }
        }
        public new float RZ
        {
            get => _jobj.RZ;
            set
            {
                if (_jobj != null)
                    _jobj.RZ = value;
                base.RZ = value;
            }
        }


        public new float SX
        {
            get => base.SX;
            set
            {
                if (_jobj != null)
                    _jobj.SX = value;
                base.SX = value;
            }
        }
        public new float SY
        {
            get => base.SY;
            set
            {
                if (_jobj != null)
                    _jobj.SY = value;
                base.SY = value;
            }
        }
        public new float SZ
        {
            get => base.SZ;
            set
            {
                if (_jobj != null)
                    _jobj.SZ = value;
                base.SZ = value;
            }
        }
    }
}
