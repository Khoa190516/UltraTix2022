﻿using System;
using System.Collections.Generic;

namespace UltraTix2022.API.UltraTix2022.Data.Models.Entities
{
    public partial class SystemToOrganizerTransaction
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; } = null!;
        public Guid SystemWalletId { get; set; }
        public Guid OrganizerWalletId { get; set; }

        public virtual AppTransaction IdNavigation { get; set; } = null!;
    }
}
