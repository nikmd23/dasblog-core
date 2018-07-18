﻿namespace DasBlog.Core
{
	public enum EventCodes : int
	{
		Error = 1,
		StorageError,
		SmtpError,
		EntryAdded = 100,
		EntryChanged,
		EntryDeleted,
		CommentAdded = 200,
		CommentChanged,
		CommentDeleted,
		CommentApproved,
		CommentEmail,
		CommentBlocked,
		TrackbackSent = 300,
		TrackbackReceived,
		TrackbackBlocked,
		TrackbackServerError = 350,
		PingbackSent = 400,
		PingbackReceived,
		PingbackBlocked,
		PingbackServerError = 450,
		ReferralReceived = 500,
		ItemReferralReceived,
		ReferralBlocked,
		ItemReferralBlocked,
		ItemReferralDeleted,
		Pop3EntryReceived = 600,
		Pop3EntryIgnored,
		Pop3EntryDiscarded,
		Pop3ServiceStart = 620,
		Pop3ServiceShutdown,
		Pop3ServerError = 650,
		XSSUpstreamSuccess = 700,
		XSSServiceStart = 720,
		XSSServiceShutdown,
		XSSUpstreamError = 750,
		PingWeblogsError = 800,
		Search = 900,
		CrosspostAdded = 1000,
		CrosspostChanged,
		CrosspostDeleted,
		ReportMailerReportSent = 1100,
		ReportMailerServiceStart = 1120,
		ReportMailerServiceShutdown,
		ReportMailerServiceError = 1150,
		SecurityFailure = 5000,
		SecuritySuccess,
		ApplicationStartup = 32000,
	}
}
