using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Backend.Helper;
using Microsoft.AspNetCore.Authorization;
using Backend.Models;
using Backend.Services;
using Backend.Services.Interface;
using Backend.RealTime;


namespace Backend.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{

		private readonly IUserService _userContext;

		private readonly GroupChatService _group;
		private readonly MediaService _media;

		private readonly RequestNotiService _NotiContext;
		private readonly PostNotiService _PostContext;

		public UserController(MediaService media, GroupChatService group, IUserService UserContext, RequestNotiService NotiContext, PostNotiService PostContext)
		{
			_group = group;
			_media = media;
			_userContext = UserContext;
			_NotiContext = NotiContext;
			_PostContext = PostContext;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok(await _userContext.GetAll());
		}

		// [HttpGet("friends-by-name")]
		// public async Task<IActionResult> GetFriendsByName([FromQuery] string name)
		// {
		// 	var UserId = MiddleWare.GetUserIdFromCookie(Request);
		// 	try
		// 	{
		// 		var friends = await _userContext.GetFriendsByName(UserId, name);
		// 		foreach (var item in friends)
		// 		{
		// 			item.ChatInMessages = await _detailmess.GetMessage(UserId, item.UserId);
		// 		}
		// 		return Ok(friends);
		// 	}
		// 	catch (System.Exception ex)
		// 	{
		// 		return BadRequest("Lỗi: " + ex);
		// 		throw;
		// 	}
		// }


		[HttpGet("user-login")]
		public async Task<IActionResult> FindById()
		{
			Console.WriteLine("hâhhha");
			var userId = MiddleWare.GetUserIdFromCookie(Request);
			if (userId == -1) return null;

			var information = await _userContext.GetLoginById(userId);
			var friends = await _userContext.GetFriends(userId);
			// var groupchat = await _group.FindByUserId(userId);
			var requests = await _NotiContext.FindByUserId(userId);
			// var media = await _media.FindProfilePictureByUserId(userId);
			var postrequests = await _PostContext.FindByUserId(userId);
			return Ok(new { information = information, friends = friends, requests = requests, postrequests = postrequests });
		}

		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Put([FromBody] User user)
		{
			user.GenderId ??= 0;
			return Ok(new { result = await _userContext.Add(user) });
		}

		[HttpGet("users-by-name")]
		public async Task<IActionResult> GetListByName([FromQuery] string name)
		{
			var UserId = MiddleWare.GetUserIdFromCookie(Request);
			var list = await _userContext.GetListByName(name, UserId);
			// foreach (var item in list)
			// {
			// 	item.ProfilePicture = await _media.FindProfilePictureByUserId(item.UserId);
			// }
			return Ok(list);
		}


		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}