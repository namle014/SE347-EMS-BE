﻿using OA.Core.Constants;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using static OA.Core.Constants.MsgConstants;

namespace OA.Domain.VModels
{
    public class ErrorReportCreateVModel
    {
        public string? ReportedBy { get; set; }
        public DateTime? ReportedDate { get; set; }
        public string? Type { get; set; }
        public string? TypeId { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? ResolvedBy { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string? ResolutionDetails { get; set; }
    }

    public class ErrorReportUpdateVModel : ErrorReportCreateVModel
    {
        public int Id { get; set; }
    }

    public class FilterErrorReportVModel
    {
        public bool? IsActive { get; set; } = true;
        public DateTime? CreatedDate { get; set; }
        [Range(1, int.MaxValue)]
        public int PageSize { get; set; } = CommonConstants.ConfigNumber.pageSizeDefault;
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; } = 1;
        public string? SortBy { get; set; }
        public bool IsExport { get; set; } = false;
        public bool IsDescending { get; set; } = true;
        public string? Keyword { get; set; }
        public string? IsType { get; set; }
    }

    public class ErrorReportExportVModel
    {
        public string? ReportedBy { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? ReportedDate { get; set; }
        public DateTime? ResolvedDate { get; set; }
    }

}
