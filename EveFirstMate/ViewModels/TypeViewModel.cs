using EveFirstMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EveFirstMate.ViewModels
{
    public class TypeViewModel
    {
        #region Model

        private invType _type;
        private invType ItemType
        {
            get
            {
                if (_type == null)
                    _type = new invType();
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        #endregion // Model

        #region invType Properties

        public int typeID
        {
            get { return ItemType.typeID; }
            set { ItemType.typeID = value; }
        }
        public Nullable<int> groupID
        {
            get { return ItemType.groupID; }
            set { ItemType.groupID = value; }
        }
        public string typeName
        {
            get { return ItemType.typeName; }
            set { ItemType.typeName = value; }
        }
        public string description
        {
            get { return ItemType.description; }
            set { ItemType.description = value; }
        }
        public Nullable<double> mass
        {
            get { return ItemType.mass; }
            set { ItemType.mass = value; }
        }
        public Nullable<double> volume
        {
            get { return ItemType.volume; }
            set { ItemType.volume = value; }
        }
        public Nullable<double> capacity
        {
            get { return ItemType.capacity; }
            set { ItemType.capacity = value; }
        }
        public Nullable<int> portionSize
        {
            get { return ItemType.portionSize; }
            set { ItemType.portionSize = value; }
        }
        public Nullable<byte> raceID
        {
            get { return ItemType.raceID; }
            set { ItemType.raceID = value; }
        }
        public Nullable<decimal> basePrice
        {
            get { return ItemType.basePrice; }
            set { ItemType.basePrice = value; }
        }
        public Nullable<bool> published
        {
            get { return ItemType.published; }
            set { ItemType.published = value; }
        }
        public Nullable<int> marketGroupID
        {
            get { return ItemType.marketGroupID; }
            set { ItemType.marketGroupID = value; }
        }
        public Nullable<double> chanceOfDuplicating
        {
            get { return ItemType.chanceOfDuplicating; }
            set { ItemType.chanceOfDuplicating = value; }
        }
        public Nullable<int> graphicID
        {
            get { return ItemType.graphicID; }
            set { ItemType.graphicID = value; }
        }
        public Nullable<double> radius
        {
            get { return ItemType.radius; }
            set { ItemType.radius = value; }
        }
        public Nullable<int> soundID
        {
            get { return ItemType.soundID; }
            set { ItemType.soundID = value; }
        }
        public Nullable<int> iconID
        {
            get { return ItemType.iconID; }
            set { ItemType.iconID = value; }
        }

        #endregion // invType Properties

        #region Constructors

        public TypeViewModel()
        {
        }

        public TypeViewModel(invType itemType)
        {
            this.ItemType = itemType;
        }

        #endregion // Constructors
    }
}