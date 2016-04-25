﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by TrackableData.CodeGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using TrackableData;
using EntityNetwork;
using ProtoBuf;
using TypeAlias;

#region ISpaceShipData

namespace Domain.Entity
{
    [ProtoContract]
    public partial class TrackableSpaceShipData : ISpaceShipData
    {
        [IgnoreDataMember]
        public IPocoTracker<ISpaceShipData> Tracker { get; set; }

        [IgnoreDataMember]
        public bool Changed { get { return Tracker != null && Tracker.HasChange; } }

        ITracker ITrackable.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ISpaceShipData>)value;
                Tracker = t;
            }
        }

        ITracker<ISpaceShipData> ITrackable<ISpaceShipData>.Tracker
        {
            get
            {
                return Tracker;
            }
            set
            {
                var t = (IPocoTracker<ISpaceShipData>)value;
                Tracker = t;
            }
        }

        public ITrackable GetChildTrackable(object name)
        {
            switch ((string)name)
            {
                default:
                    return null;
            }
        }

        public IEnumerable<KeyValuePair<object, ITrackable>> GetChildTrackables(bool changedOnly = false)
        {
            yield break;
        }

        public static class PropertyTable
        {
            public static readonly PropertyInfo Hp = typeof(ISpaceShipData).GetProperty("Hp");
            public static readonly PropertyInfo Score = typeof(ISpaceShipData).GetProperty("Score");
        }

        private float _Hp;

        [ProtoMember(1)] 
        public float Hp
        {
            get
            {
                return _Hp;
            }
            set
            {
                if (Tracker != null && Hp != value)
                    Tracker.TrackSet(PropertyTable.Hp, _Hp, value);
                _Hp = value;
            }
        }

        private float _Score;

        [ProtoMember(2)] 
        public float Score
        {
            get
            {
                return _Score;
            }
            set
            {
                if (Tracker != null && Score != value)
                    Tracker.TrackSet(PropertyTable.Score, _Score, value);
                _Score = value;
            }
        }
    }

    [ProtoContract]
    public class TrackableSpaceShipDataTrackerSurrogate
    {
        [ProtoMember(1)] public EnvelopedObject<float> Hp;
        [ProtoMember(2)] public EnvelopedObject<float> Score;

        public static implicit operator TrackableSpaceShipDataTrackerSurrogate(TrackablePocoTracker<ISpaceShipData> tracker)
        {
            if (tracker == null)
                return null;

            var surrogate = new TrackableSpaceShipDataTrackerSurrogate();
            foreach(var changeItem in tracker.ChangeMap)
            {
                switch (changeItem.Key.Name)
                {
                    case "Hp":
                        surrogate.Hp = new EnvelopedObject<float> { Value = (float)changeItem.Value.NewValue };
                        break;
                    case "Score":
                        surrogate.Score = new EnvelopedObject<float> { Value = (float)changeItem.Value.NewValue };
                        break;
                }
            }

            return surrogate;
        }

        public static implicit operator TrackablePocoTracker<ISpaceShipData>(TrackableSpaceShipDataTrackerSurrogate surrogate)
        {
            if (surrogate == null)
                return null;

            var tracker = new TrackablePocoTracker<ISpaceShipData>();
            if (surrogate.Hp != null)
                tracker.ChangeMap.Add(TrackableSpaceShipData.PropertyTable.Hp, new TrackablePocoTracker<ISpaceShipData>.Change { NewValue = surrogate.Hp.Value });
            if (surrogate.Score != null)
                tracker.ChangeMap.Add(TrackableSpaceShipData.PropertyTable.Score, new TrackablePocoTracker<ISpaceShipData>.Change { NewValue = surrogate.Score.Value });
            return tracker;
        }
    }
}

#endregion
