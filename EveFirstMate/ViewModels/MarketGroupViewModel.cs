using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EveFirstMate.Models;

namespace EveFirstMate.ViewModels
{
    public class MarketGroupViewModel
    {
        private invMarketGroup _invMarketGroup;
        private invMarketGroup MarketGroup
        {
            get
            {
                if (_invMarketGroup == null)
                    _invMarketGroup = new invMarketGroup();
                return _invMarketGroup;
            }
            set
            {
                _invMarketGroup = value;
            }
        }

        #region invMarketGroup Properties

        public int marketGroupID
        {
            get
            {
                return MarketGroup.marketGroupID;
            }
            set
            {
                MarketGroup.marketGroupID = value;
            }
        }
        public Nullable<int> parentGroupID
        {
            get
            {
                return MarketGroup.parentGroupID;
            }
            set
            {
                MarketGroup.parentGroupID = value;
            }
        }
        public string marketGroupName
        {
            get
            {
                return MarketGroup.marketGroupName;
            }
            set
            {
                MarketGroup.marketGroupName = value;
            }
        }
        public string description
        {
            get
            {
                return MarketGroup.description;
            }
            set
            {
                MarketGroup.description = value;
            }
        }
        public Nullable<int> iconID
        {
            get
            {
                return MarketGroup.iconID;
            }
            set
            {
                MarketGroup.iconID = value;
            }
        }
        public Nullable<bool> hasTypes
        {
            get
            {
                return MarketGroup.hasTypes;
            }
            set
            {
                MarketGroup.hasTypes = value;
            }
        }

        public List<invMarketGroup> childMarketGroups
        {
            get
            {
                return MarketGroup.invMarketGroups1.ToList();
            }
            set
            {
                MarketGroup.invMarketGroups1 = value;
            }
        }
        public List<invType> invTypes
        {
            get
            {
                return MarketGroup.invTypes.ToList();
            }
            set
            {
                MarketGroup.invTypes = value;
            }
        }
        public eveIcon eveIcon
        {
            get
            {
                return MarketGroup.eveIcon;
            }
            set
            {
                MarketGroup.eveIcon = value;
            }
        }

        #endregion // invMarketGroup Properties

        public MarketGroupViewModel()
        {
            this.MarketGroup.invMarketGroup1 = null;
        }

        public MarketGroupViewModel(invMarketGroup marketGroup)
        {
            this.MarketGroup = marketGroup;
            this.MarketGroup.invMarketGroup1 = null;
        }
    }
}