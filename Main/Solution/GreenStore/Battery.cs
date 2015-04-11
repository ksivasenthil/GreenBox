using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace GreenStore
{
    public class Battery : DbContext
    {
        private DbSet<MyPath> PathTable;
        private DbSet<MyTrack> TrackTable;
        private DbSet<PathLeg> LegTable;
        private DbSet<PathStep> StepTable;
        private DbSet<TrackSegment> SegmentTable;
        private DbSet<TrackPoint> PointTable;
        private DbSet<FuelType> FuelTypeTable;
        private DbSet<TransportMode> TransportModeTable;
        private DbSet<VehicleType> VehicleTypeTable;
        private DbSet<VehicleSubType> VehicleSubTypeTable;

        public Battery(string connectionName)
            : base("name=" + connectionName)
        {

        }

        #region Properties
        private DbSet<MyPath> PathHandle { get { return PathTable ?? this.Set<MyPath>(); } }
        private DbSet<MyTrack> TrackHandle { get { return TrackTable ?? this.Set<MyTrack>(); } }
        private DbSet<PathLeg> LegHandle { get { return LegTable ?? this.Set<PathLeg>(); } }
        private DbSet<PathStep> StepHandle { get { return StepTable ?? this.Set<PathStep>(); } }
        private DbSet<TrackSegment> SegmentHandle { get { return SegmentTable ?? this.Set<TrackSegment>(); } }
        private DbSet<TrackPoint> PointHandle { get { return PointTable ?? this.Set<TrackPoint>(); } }
        private DbSet<FuelType> FuelTypeHandle { get { return FuelTypeTable ?? this.Set<FuelType>(); } }
        private DbSet<TransportMode> TransportModeHandle { get { return TransportModeTable ?? this.Set<TransportMode>(); } }
        private DbSet<VehicleType> VehicleTypeHandle { get { return VehicleTypeTable ?? this.Set<VehicleType>(); } }
        private DbSet<VehicleSubType> VehicleSubTypeHandle { get { return VehicleSubTypeTable ?? this.Set<VehicleSubType>(); } }
        #endregion

#if DEBUG
        public virtual IEnumerable<VehicleType> Where(Expression<Func<VehicleType, bool>> condition)
#elif RELEASE
        public IEnumerable<VehicleType> Where(Expression<Func<VehicleType, bool>> condition)

#endif
        {
            IEnumerable<VehicleType> searchResult = new List<VehicleType>();

            var queryResult = this.VehicleTypeHandle.Where(condition);

            bool valueObtained = null != searchResult;
            if (valueObtained)
            {
                searchResult = queryResult.AsEnumerable<VehicleType>();
            }
            return searchResult;
        }
#if DEBUG
        public virtual IEnumerable<VehicleSubType> Where(Expression<Func<VehicleSubType, bool>> condition)
#elif RELEASE
        public IEnumerable<VehicleSubType> Where(Expression<Func<VehicleSubType, bool>> condition)

#endif
        {
            IEnumerable<VehicleSubType> searchResult = new List<VehicleSubType>();

            var queryResult = this.VehicleSubTypeHandle.Where(condition);

            bool valueObtained = null != searchResult;
            if (valueObtained)
            {
                searchResult = queryResult.AsEnumerable<VehicleSubType>();
            }
            return searchResult;
        }
#if DEBUG
        public virtual VehicleSubType FindOne(params object[] keys)
#elif RELEASE
        public VehicleSubType FindOne(params object[] keys)
#endif
        {
            VehicleSubType soughtRecord;
            try
            {
                soughtRecord = this.VehicleSubTypeHandle.Find(keys);
            }
            catch (Exception ex)
            {
                //TODO: Log the exception to disk
                throw;
            }
            bool recordNoFound = null == soughtRecord;
            if (recordNoFound)
            {
                soughtRecord = null;
            }
            return soughtRecord;
        }

        #region Event Handling
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MessagePing>().ToTable("Messages");
            base.OnModelCreating(modelBuilder);
            bindPrivateProperties(modelBuilder, "mileageDec", "Mileage");
            bindPrivateProperties(modelBuilder, "heatingValueDec", "HeatingValue");
            bindPrivateProperties(modelBuilder, "co2EmissionFactorDec", "CO2EmissionFactor");
            bindPrivateProperties(modelBuilder, "errorMarginDec", "ErrorMargin");
        }
        private void bindPrivateProperties(DbModelBuilder modelBuilder, string privateProperty, string publicProperty)
        {
            modelBuilder.Types().Configure(c =>
            {
                var mileageProps = c.ClrType.GetProperties(BindingFlags.NonPublic
                                             | BindingFlags.Instance)
                              .Where(p => p.Name == privateProperty);
                foreach (var p in mileageProps)
                {
                    c.Property(p).HasColumnName(publicProperty);
                }

            });
        }
        #endregion
    }

}

