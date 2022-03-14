using System.Data.Common;
using ConsoleApp2.Models;
using Hapi.SDK.Core.Models.v3;
using Reservation = Hapi.SDK.Core.Models.v3.Reservation;

namespace ConsoleApp2.Extensions;

public static class ReservationDiffExtension
{
    public static Reservation ToV3(this ConsoleApp2.Models.ReservationDiff source,
        ReservationNotificationType notificationType,
        ReservationStatus reservationStatus)
    {
        var result = new Reservation
        {
            PropertyDetails = new PropertyDetails()
            {
                Code = source.PropertyCode,
                ChainCode = source.ChainCode
            },
            NotificationType = notificationType,
            ReferenceIds = new List<ReferenceId>(),
            Status = reservationStatus,
            CreatedDateTime = source.NewValues.CreateDate,
            LastModifiedDateTime = source.NewValues.UpdateDate.HasValue
                ? source.NewValues.UpdateDate
                : source.NewValues.CreateDate,
            Arrival = source.NewValues.TruncArrival?.ToDateTime(TimeOnly.MinValue),
            EstimatedDateTimeOfArrival = source.NewValues.TruncArrival.HasValue && source.NewValues.ArrivalTime.HasValue
                ? source.NewValues.TruncArrival.Value.ToDateTime(source.NewValues.ArrivalTime.Value)
                : null,
            Departure = source.NewValues.TruncDeparture?.ToDateTime(TimeOnly.MinValue),
            ActualDateTimeOfDeparture =
                source.NewValues.TruncDeparture.HasValue && source.NewValues.DepartureTime.HasValue
                    ? source.NewValues.TruncDeparture.Value.ToDateTime(source.NewValues.DepartureTime.Value)
                    : null,
            OccupancyDetails = new List<OccupancyDetails>(),
        };

        if (source.NewValues.ResvNameId.HasValue)
        {
            result.ReferenceIds.Add(new ReferenceId()
            {
                SystemId = "Opera",
                SystemType = "PMS",
                IdType = ReferenceIdIdType.RESERVATION_ID,
                Id = source.NewValues.ResvNameId.Value.ToString()
            });
        }

        if (source.NewValues.ConfirmationNo != null)
        {
            result.ReferenceIds.Add(new ReferenceId()
            {
                SystemId = "Opera",
                SystemType = "PMS",
                IdType = ReferenceIdIdType.CONFIRMATION_NUMBER,
                Id = source.NewValues.ConfirmationNo
            });
        }

        if (source.NewValues.ExternalReference != null)
        {
            result.ReferenceIds.Add(new ReferenceId()
            {
                SystemId = "EXTERNAL",
                IdType = ReferenceIdIdType.RESERVATION_ID,
                Id = source.NewValues.ExternalReference
            });
        }

        if (!string.IsNullOrEmpty(source.NewValues.RoomCategoryLabel))
        {
            result.BookedUnits = new List<BookedReservationUnitDetails>()
            {
                new BookedReservationUnitDetails()
                {
                    Start = source.NewValues.TruncArrival.Value.ToDateTime(TimeOnly.MinValue),
                    End = source.NewValues.TruncDeparture.Value.ToDateTime(TimeOnly.MinValue),
                    UnitCount = 1,
                    UnitTypeCode = source.NewValues.RoomCategoryLabel
                }
            };
        }

        if (!string.IsNullOrEmpty(source.NewValues.Room))
        {
            result.OccupiedUnits = new List<OccupiedReservationUnitDetails>()
            {
                new OccupiedReservationUnitDetails()
                {
                    Start = source.NewValues.TruncArrival.Value.ToDateTime(TimeOnly.MinValue),
                    End = source.NewValues.TruncDeparture.Value.ToDateTime(TimeOnly.MinValue),
                    UnitId = source.NewValues.Room,
                    UnitTypeCode = source.NewValues.RoomCategoryLabel
                }
            };
        }

        if (source.NewValues.Adults.HasValue || source.NewValues.Children.HasValue)
        {
            result.OccupancyDetails = new List<OccupancyDetails>()
            {
                new OccupancyDetails()
                {
                    Start = source.NewValues.TruncArrival.Value.ToDateTime(TimeOnly.MinValue),
                    End = source.NewValues.TruncDeparture.Value.ToDateTime(TimeOnly.MinValue),
                    IsPerUnit = true,
                    Occupants = new List<Occupants>()
                }
            };

            if (source.NewValues.Adults.HasValue)
            {
                result.OccupancyDetails.First().Occupants.Add(new Occupants()
                {
                    Type = OccupantsType.ADULT,
                    Count = source.NewValues.Adults.Value
                });
            }

            if (source.NewValues.Children.HasValue)
            {
                result.OccupancyDetails.First().Occupants.Add(new Occupants()
                {
                    Type = OccupantsType.CHILD,
                    Count = source.NewValues.Children.Value
                });
            }
        }

        if (!string.IsNullOrEmpty(source.NewValues.CurrencyCode))
        {
            result.Currency = new Currency()
            {
                Code = source.NewValues.CurrencyCode
            };
        }

        if (!string.IsNullOrEmpty(source.NewValues.RateCode))
        {
            result.RatePlans = new List<RatePlan>()
            {
                new RatePlan()
                {
                    Start = source.NewValues.TruncArrival.Value.ToDateTime(TimeOnly.MinValue),
                    End = source.NewValues.TruncDeparture.Value.ToDateTime(TimeOnly.MinValue),
                    Code = source.NewValues.RateCode
                }
            };
        }

        if (source.NewValues.ShareAmount.HasValue)
        {
            result.Prices = new List<Price>()
            {
                new Price()
                {
                    Start = source.NewValues.TruncArrival.Value.ToDateTime(TimeOnly.MinValue),
                    End = source.NewValues.TruncDeparture.Value.ToDateTime(TimeOnly.MinValue),
                    Amount = source.NewValues.ShareAmount.Value
                }
            };
        }

        if (!string.IsNullOrEmpty(source.Pii.MemberNumber) && !string.IsNullOrEmpty(source.NewValues.MembershipType))
        {
            result.Memberships = new List<Membership>()
            {
                new Membership()
                {
                    Level = source.NewValues.MembershipLevel,
                    MembershipCode = source.NewValues.MembershipType,
                    Id = source.Pii.MemberNumber
                }
            };
        }

        if (!string.IsNullOrEmpty(source.NewValues.CompanyName) && source.NewValues.CompanyId.HasValue)
        {
            result.Profiles = new List<Profile>();
            if (!string.IsNullOrEmpty(source.NewValues.CompanyName) && source.NewValues.CompanyId.HasValue)
            {
                result.Profiles.Add(new Profile()
                {
                    PropertyDetails = result.PropertyDetails,
                    ReferenceIds = new List<ReferenceId>()
                    {
                        new ReferenceId()
                        {
                            SystemId = "Opera",
                            SystemType = "PMS",
                            IdType = ReferenceIdIdType.PROFILE_ID,
                            Id = source.NewValues.CompanyId.Value.ToString()
                        }
                    },
                    Names = new List<ProfileName>()
                    {
                        new ProfileName()
                        {
                            Name = source.NewValues.CompanyName,
                            Type = ProfileNameType.PRIMARY
                        }
                    }
                });
            }
        }

        if (!string.IsNullOrEmpty(source.NewValues.TravelAgentName) && source.NewValues.TravelAgentId.HasValue)
        {
            result.Profiles ??= new List<Profile>();
            result.Profiles.Add(new Profile()
            {
                PropertyDetails = result.PropertyDetails,
                ReferenceIds = new List<ReferenceId>()
                {
                    new ReferenceId()
                    {
                        SystemId = "Opera",
                        SystemType = "PMS",
                        IdType = ReferenceIdIdType.PROFILE_ID,
                        Id = source.NewValues.TravelAgentId.Value.ToString()
                    }
                },
                Names = new List<ProfileName>()
                {
                    new ProfileName()
                    {
                        Name = source.NewValues.TravelAgentName,
                        Type = ProfileNameType.PRIMARY
                    }
                }
            });
        }

        if (!string.IsNullOrEmpty(source.Pii.GuestLastName))
        {
            result.Guests = new List<ReservationGuest>()
            {
                new ReservationGuest()
                {
                    Guest = new Guest()
                    {
                        PropertyDetails = result.PropertyDetails,
                        Names = new List<PersonName>()
                        {
                            new PersonName()
                            {
                                Surname = source.Pii.GuestLastName,
                                GivenName = source.Pii.GuestFirstName
                            }
                        }
                    }
                }
            };

            if (source.NewValues.GuestNameId.HasValue)
            {
                result.Guests.First().Guest.ReferenceIds = new List<ReferenceId>()
                {
                    new ReferenceId()
                    {
                        SystemId = "Opera",
                        SystemType = "PMS",
                        IdType = ReferenceIdIdType.GUEST_ID,
                        Id = source.NewValues.GuestNameId.Value.ToString()
                    }
                };
            }

            if (!string.IsNullOrEmpty(source.Pii.GuestEmail))
            {
                result.Guests.First().Guest.ContactDetails = new List<ContactDetails>()
                {
                    new ContactDetails()
                    {
                        Type = "EMAIL",
                        Value = source.Pii.GuestEmail,
                        Category = ContactDetailsCategory.EMAIL
                    }
                };
            }

            if (!string.IsNullOrEmpty(source.Pii.GuestPhone))
            {
                result.Guests.First().Guest.ContactDetails ??= new List<ContactDetails>();
                result.Guests.First().Guest.ContactDetails.Add(
                    new ContactDetails()
                    {
                        Type = "PHONE",
                        Value = source.Pii.GuestPhone,
                        Category = ContactDetailsCategory.PHONE
                    }
                );
            }

            if (!string.IsNullOrEmpty(source.NewValues.Preferences))
            {
                var preferences = source.NewValues.Preferences.Split(new char[] {','});
                if (preferences.Length > 0)
                {
                    result.Guests.First().Guest.Preferences = new List<Preference>();
                    foreach (var preference in preferences)
                    {
                        result.Guests.First().Guest.Preferences.Add(new Preference() {Code = preference});
                    }
                }
            }
        }

        return result;
    }
}