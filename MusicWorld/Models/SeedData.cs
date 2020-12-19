using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MusicWorld.Models
{
	public static class SeedData
	{

		public static void EnsurePopulated(IApplicationBuilder app)
		{
			MusicDbContext context = app.ApplicationServices
				.CreateScope().ServiceProvider.GetRequiredService<MusicDbContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}
			if (!context.Albums.Any())
			{
				context.Albums.AddRange(
					new Album
					{

						AlbumName = "Đừng yêu nữa em mệt rồi(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/9/1/a/5/91a5530c22b7ed73af1cb70d5f08bf01.jpg"
					},
					new Album
					{

						AlbumName = "Gặp nhưng không ở lại(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/f/a/4/b/fa4b429fda0c4d3d2100f64ad3c7a616.jpg"
					},
					new Album
					{

						AlbumName = "Lắng nghe nước mắt(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/covers/8/6/8655400b95bb6416d07e8221567fa10f_1349062992.jpg"
					},
					new Album
					{

						AlbumName = "Chàng trai thất tình(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/cover/0/7/2/b/072ba9ae04687203d6f6af8e526ce631.jpg"
					},
					new Album
					{

						AlbumName = "Thích thì chơi(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/7/b/a/2/7ba2244c994c13bbd88f52bb2c34ae85.jpg"
					},
					new Album
					{

						AlbumName = "How you like that(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/b/3/7/a/b37a3d57924c3f6e5ae9ab6b5c5e7efe.jpg"
					},
					new Album
					{

						AlbumName = "Bang Bang Bang(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/c/a/7/e/ca7ec4eb2a33f9f7ee3afe096ac7120d.jpg"
					},
					new Album
					{

						AlbumName = "End of time(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/b/e/1/0/be10ee8806b935aab48b0e3bca279066.jpg"
					},
					new Album
					{

						AlbumName = "Save me(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/covers/3/9/39247dd8f7a4a85f35647cf2d43d82ea_1487647777.jpg"
					},
					new Album
					{

						AlbumName = "Sầu lẻ bóng(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/cover/5/1/0/1/51018bec41f581c6b9cb9e55a40e6e97.jpg"
					},
					new Album
					{

						AlbumName = "Sầu tím thiệp hồng(Single)",
						ImgAlbum = "https://photo-resize-zmp3.zadn.vn/w480_r1x1_jpeg/covers/d/4/d4061e39d04b50f810b06aefe6851484_1319448338.jpg"
					}
				);
				context.SaveChanges();
			}

			if (!context.Tracks.Any())
			{
				context.Tracks.AddRange(
					new Track
					{
						TrackName = "Đừng yêu nữa, em mệt rồi",
						Duration = "04:41",
						TrackLink = "https://zingmp3.vn/embed/song/ZWADIOCC?",
						UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/2/7/d/9/27d9bf0671538484ddc719c125cba369.jpg",
						AlbumId = 1,
						Genre = "Pop",
						ArtistName="Min"
					},
		new Track
		{

			TrackName = "Có em chờ",
			Duration = "03:54",
			TrackLink = "https://zingmp3.vn/embed/song/ZW7FODC9?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/f/3/f3ccdd27d2000e3f9255a7e3e2c48800_1493277779.jpg",
			AlbumId = 1,
			Genre = "Pop",
			ArtistName = "Min"
		},
		new Track
		{

			TrackName = "Ghen",
			Duration = "04:07",
			TrackLink = "https://zingmp3.vn/embed/song/ZW7FC0I7?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/d/0/d05f9b3c87cf7ccda468174b28757489_1495770525.jpg",
			AlbumId = 1,
			Genre = "Pop",
			ArtistName = "Min"
		},
		new Track
		{

			TrackName = "Vì yêu cứ đâm đầu",
			Duration = "03:51",
			TrackLink = "https://zingmp3.vn/embed/song/ZWB0IFW8?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/3/a/c/03ac82cbf720ea5d24129dc5a2bb5bbe.jpg",
			AlbumId = 1,
			Genre = "Pop",
			ArtistName = "Min"
		},
		new Track
		{

			TrackName = "Đừng xin lỗi nữa",
			Duration = "03:51",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9ABW0E?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/e/4/e4dabc639b203d00bbefe9d488353716_1516266450.jpg",
			AlbumId = 1,
			Genre = "Pop",
			ArtistName = "Min"
		},
		new Track
		{

			TrackName = "Gặp nhưng không ở lại",
			Duration = "04:37",
			TrackLink = "https://zingmp3.vn/embed/song/ZOI6BFA9?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/f/a/4/b/fa4b429fda0c4d3d2100f64ad3c7a616.jpg",
			AlbumId = 2,
			Genre = "Pop",
			ArtistName = "Hiền Hồ"
		},
		new Track
		{

			TrackName = "Có như không có",
			Duration = "04:34",
			TrackLink = "https://zingmp3.vn/embed/song/ZWAF8DOB?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/3/f/5/8/3f588b3f74b49a8b2c70bc771df103bd.jpg",
			AlbumId = 2,
			Genre = "Pop",
			ArtistName = "Hiền Hồ"
		},
		new Track
		{

			TrackName = "Rồi người thương cũng hóa người dưng",
			Duration = "04:38",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9C0DWE?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/b/b/5/0bb55eaf1f19451a075759258eab718d.jpg",
			AlbumId = 2,
			Genre = "Pop",
			ArtistName = "Hiền Hồ"
		},
		new Track
		{

			TrackName = "Em ngày xưa khác rồi",
			Duration = "04:48",
			TrackLink = "https://zingmp3.vn/embed/song/ZW8WUICD?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/4/f/4f33a5712c26714f0a1e7177d0b4129d_1509608464.jpg",
			AlbumId = 2,
			Genre = "Pop",
			ArtistName = "Hiền Hồ"
		},
		new Track
		{

			TrackName = "Đừng nói tôi điên",
			Duration = "04:27",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9EO8WO?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/1/2/b/8/12b88922410ad579dce22031b12c05ca.jpg",
			AlbumId = 2,
			Genre = "Pop",
			ArtistName = "Hiền Hồ"
		},
		new Track
		{

			TrackName = "Lắng nghe nước mắt",
			Duration = "05:24",
			TrackLink = "https://zingmp3.vn/embed/song/ZW6W8W9E?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/8/6/8655400b95bb6416d07e8221567fa10f_1349062992.jpg",
			AlbumId = 3,
			Genre = "Pop",
			ArtistName = "Mr.Siro"
		},
		new Track
		{

			TrackName = "Day dứt nỗi đau",
			Duration = "04:59",
			TrackLink = "https://zingmp3.vn/embed/song/ZW6DF66B?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/avatars/7/1/71e884a8168fa5a3a8c596dca8d30193_1473737667.jpg",
			AlbumId = 3,
			Genre = "Pop",
			ArtistName = "Mr.Siro"
		},
		new Track
		{

			TrackName = "Bức tranh từ nước mắt",
			Duration = "04:20",
			TrackLink = "https://zingmp3.vn/embed/song/ZW68WEZ0?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/avatars/9/0/90c61a8453cba8a9f8c2ca0c137fbade_1444583321.jpg",
			AlbumId = 3,
			Genre = "Pop",
			ArtistName = "Mr.Siro"
		},
		new Track
		{

			TrackName = "Một bước yêu vạn dặm đau",
			Duration = "04:59",
			TrackLink = "https://zingmp3.vn/embed/song/ZWABWOFZ?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg",
			AlbumId = 3,
			Genre = "Pop",
			ArtistName = "Mr.Siro"
		},
		new Track
		{

			TrackName = "Cô đơn không muốn về nhà",
			Duration = "03:15",
			TrackLink = "https://zingmp3.vn/embed/song/ZWB068E0?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/e/a/a/7/eaa7be597e6a5476336affd96ca5eab3.jpg",
			AlbumId = 3,
			Genre = "Pop",
			ArtistName = "Mr.Siro"
		},
		new Track
		{

			TrackName = "Chàng trai đang thất tình",
			Duration = "04:46",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9BOWIF?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/avatars/c/5/c5c7d43a4c72761be22c07e3db01cd0e_1511498945.jpg",
			AlbumId = 5,
			Genre = "Rap",
			ArtistName = "Binz"
		},
		new Track
		{

			TrackName = "BlackJack",
			Duration = "03:17",
			TrackLink = "https://zingmp3.vn/embed/song/ZOW0OBU8?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/4/0/5/6/40564f839b476fd66838e497796a3d5f.jpg",
			AlbumId = 5,
			Genre = "Rap",
			ArtistName = "Binz"
		},
		new Track
		{

			TrackName = "BigcityBoy",
			Duration = "04:13",
			TrackLink = "https://zingmp3.vn/embed/song/ZWCOE0E8?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/5/a/5/1/5a5164496ababbca1496193ec8b8afb1.jpg",
			AlbumId = 5,
			Genre = "Rap",
			ArtistName = "Binz"
		},
		new Track
		{

			TrackName = "OK",
			Duration = "02:34",
			TrackLink = "https://zingmp3.vn/embed/song/ZWB0U608?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/7/2/b/072ba9ae04687203d6f6af8e526ce631.jpg",
			AlbumId = 5,
			Genre = "Rap",
			ArtistName = "Binz"
		},
		new Track
		{

			TrackName = "SOFAR",
			Duration = "03:25",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9CD0E8?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/e/7/a/6/e7a669cae8bc05724a59bae10a9e02d3.jpg",
			AlbumId = 5,
			Genre = "Rap",
			ArtistName = "Binz"
		},
		new Track
		{

			TrackName = "Thích thì chơi",
			Duration = "03:25",
			TrackLink = "https://zingmp3.vn/embed/song/ZWCO68F0?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/e/7/a/6/e7a669cae8bc05724a59bae10a9e02d3.jpg",
			AlbumId = 4,
			Genre = "Rap",
			ArtistName = "Phúc Du"
		},
		new Track
		{

			TrackName = "Tộc ca",
			Duration = "03:11",
			TrackLink = "https://zingmp3.vn/embed/song/ZWAFU7A8?",
			UrlImg = "https://photo-zmp3.zadn.vn/audio_default.png",
			AlbumId = 4,
			Genre = "Rap",
			ArtistName = "Phúc Du"
		},
		new Track
		{

			TrackName = "Anh không làm gì đâu anh thề",
			Duration = "03:08",
			TrackLink = "https://zingmp3.vn/embed/song/ZWA979O7?",
			UrlImg = "https://photo-zmp3.zadn.vn/audio_default.png",
			AlbumId = 4,
			Genre = "Rap",
			ArtistName = "Phúc Du"
		},
		new Track
		{

			TrackName = "Cần cẩu",
			Duration = "02:35",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9BB96C?",
			UrlImg = "https://photo-zmp3.zadn.vn/audio_default.png",
			AlbumId = 4,
			Genre = "Rap",
			ArtistName = "Phúc Du"
		},
		new Track
		{

			TrackName = "Vô học",
			Duration = "01:13",
			TrackLink = "https://zingmp3.vn/embed/song/ZW9BIZ8F?",
			UrlImg = "https://photo-zmp3.zadn.vn/audio_default.png",
			AlbumId = 4,
			Genre = "Rap",
			ArtistName = "Phúc Du"
		},
		new Track
		{

			TrackName = "How you like that",
			Duration = "03:01",
			TrackLink = "https://zingmp3.vn/embed/song/ZWBU778A?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/0/4/1/0041083628270504efdb6499396aacea.jpg",
			AlbumId = 6,
			Genre = "Kpop",
			ArtistName = "BLACKPINK"
		},
		new Track
		{

			TrackName = "BOMBAYAH",
			Duration = "04:01",
			TrackLink = "https://zingmp3.vn/embed/song/ZW7UF079?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/f/8/4/5/f8456a22c05f9b96e0e832ae0b643bf0.jpg",
			AlbumId = 6,
			Genre = "Kpop",
			ArtistName = "BLACKPINK"
		},
		new Track
		{

			TrackName = "Lovesick Girl",
			Duration = "03:32",
			TrackLink = "https://zingmp3.vn/embed/song/ZWDFDW0B?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/0/4/1/0041083628270504efdb6499396aacea.jpg",
			AlbumId = 6,
			Genre = "Kpop",
			ArtistName = "BLACKPINK"
		},
		 new Track
		 {

			 TrackName = "Kill this love",
			 Duration = "03:09",
			 TrackLink = "https://zingmp3.vn/embed/song/ZWACDBZ6?",
			 UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/0/4/1/0041083628270504efdb6499396aacea.jpg",
			 AlbumId = 6,
			 Genre = "Kpop",
			 ArtistName = "BLACKPINK"
		 },
		new Track
		{

			TrackName = "WHISTLE",
			Duration = "03:32",
			TrackLink = "https://zingmp3.vn/embed/song/ZW7UF080?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/f/8/4/5/f8456a22c05f9b96e0e832ae0b643bf0.jpg",
			AlbumId = 6,
			Genre = "Kpop",
			ArtistName = "BLACKPINK"
		},
		new Track
		{

			TrackName = "Bang Bang Bang",
			Duration = "03:40",
			TrackLink = "https://zingmp3.vn/embed/song/ZW7IUB6B?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/d/5/c/0d5c63ab2960f907a293fb86fd38f679.jpg",
			AlbumId = 7,
			Genre = "Kpop",
			ArtistName = "BIGBANG"
		},
		new Track
		{

			TrackName = "LOSER",
			Duration = "03:39",
			TrackLink = "https://zingmp3.vn/embed/song/ZW70EZDD?",
			UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/d/5/c/0d5c63ab2960f907a293fb86fd38f679.jpg",
			AlbumId = 7,
			Genre = "Kpop",
			ArtistName = "BIGBANG"
		},
	   new Track
	   {

		   TrackName = "Let's not fall in love",
		   Duration = "03:32",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW7WW80U?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/d/5/c/0d5c63ab2960f907a293fb86fd38f679.jpg",
		   AlbumId = 7,
		   Genre = "Kpop",
		   ArtistName = "BIGBANG"
	   },
	   new Track
	   {

		   TrackName = "TONIGHT",
		   Duration = "03:44",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWZEBEFC?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/2/3/a/023a13017664f8707b56b112a247e478.jpg",
		   AlbumId = 7,
		   Genre = "Kpop",
		   ArtistName = "BIGBANG"
	   },
	   new Track
	   {

		   TrackName = "SOBER",
		   Duration = "03:58",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW7IAEWU?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/0/d/5/c/0d5c63ab2960f907a293fb86fd38f679.jpg",
		   AlbumId = 7,
		   Genre = "Kpop",
		   ArtistName = "BIGBANG"
	   },
	   new Track
	   {

		   TrackName = "End of time",
		   Duration = "03:08",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWBIFCUD?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/6/7/6/b/676be782f9b5e5951dfd7333d55211d2.jpg",
		   AlbumId = 8,
		   Genre = "EDM",
		   ArtistName = "Alan Walker"
	   },
	   new Track
	   {

		   TrackName = "Play",
		   Duration = "02:48",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWBIFCUE?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/9/f/4/e/9f4e2b8f713753e9aced9fcbed3e9c7e.jpg",
		   AlbumId = 8,
		   Genre = "EDM",
		   ArtistName = "Alan Walker"
	   },
	   new Track
	   {

		   TrackName = "On my way",
		   Duration = "03:21",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWABOA0F?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/e/0/4/3/e04371bab7e3a83acf96e56e1df884d6.jpg",
		   AlbumId = 8,
		   Genre = "EDM",
		   ArtistName = "Alan Walker"
	   },
	   new Track
	   {

		   TrackName = "Lily",
		   Duration = "03:40",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWA0OA6F?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/4/a/2/9/4a2973c762fa678dbdbce569bf26b2f0.jpg",
		   AlbumId = 8,
		   Genre = "EDM",
		   ArtistName = "Alan Walker"
	   },
	   new Track
	   {

		   TrackName = "All Falls Down",
		   Duration = "03:19",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW8WOI6U?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/c/d/cd5e9fea8071c159d382eded303e3a8c_1509329820.jpg",
		   AlbumId = 8,
		   Genre = "EDM",
		   ArtistName = "Alan Walker"
	   },
	   new Track
	   {

		   TrackName = "Save me",
		   Duration = "03:05",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW79FA6Z?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/3/9/39247dd8f7a4a85f35647cf2d43d82ea_1487647777.jpg",
		   AlbumId = 9,
		   Genre = "EDM",
		   ArtistName = "DEAMS"
	   },
	   new Track
	   {

		   TrackName = "Sign",
		   Duration = "03:12",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW9ABBFZ?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/c/d/cd5e9fea8071c159d382eded303e3a8c_1509329820.jpg",
		   AlbumId = 9,
		   Genre = "EDM",
		   ArtistName = "DEAMS"
	   },
	   new Track
	   {

		   TrackName = "Drive my car",
		   Duration = "03:17",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW7FI0DI?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/9/c/9cb73f8d6d25437de31bcccf60d71af8_1492504627.jpg",
		   AlbumId = 9,
		   Genre = "EDM",
		   ArtistName = "DEAMS"
	   },
	   new Track
	   {

		   TrackName = "Summer Love",
		   Duration = "03:21",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW9ABBFU?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/6/6/66a76d98e302493f0faeed53a0d9436e_1516362467.jpg",
		   AlbumId = 9,
		   Genre = "EDM",
		   ArtistName = "DEAMS"
	   },
	   new Track
	   {

		   TrackName = "Flight",
		   Duration = "03:05",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWB0OIEZ?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/cover/1/a/e/4/1ae486b36a0eeacd9623d2048c56c2b3.jpg",
		   AlbumId = 9,
		   Genre = "EDM",
		   ArtistName = "DEAMS"
	   },
	   new Track
	   {

		   TrackName = "Sầu lẻ bóng",
		   Duration = "05:18",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWZ96WWD?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/0/c/0c1485a24cf001c56223be2879ae5f26_1290654489.jpg",
		   AlbumId = 10,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Lệ Quyên"
	   },
	   new Track
	   {

		   TrackName = "Về đâu mái tóc người thương",
		   Duration = "04:50",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW7I9WD0?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/1/e/1ea49f00f05ad0fff61a7a2c9110a1c1_1434966798.jpg",
		   AlbumId = 10,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Lệ Quyên"
	   },
	   new Track
	   {

		   TrackName = "Tình lỡ",
		   Duration = "05:53",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWZ96WIC?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/0/c/0c1485a24cf001c56223be2879ae5f26_1290654489.jpg",
		   AlbumId = 10,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Lệ Quyên"
	   },
	   new Track
	   {

		   TrackName = "Buồn",
		   Duration = "04:20",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWZ96WO6?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/0/c/0c1485a24cf001c56223be2879ae5f26_1290654489.jpg",
		   AlbumId = 10,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Lệ Quyên"
	   },
	   new Track
	   {

		   TrackName = "Nỗi đau ngự trị",
		   Duration = "04:41",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWZBFB9D?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/0/7/07c1bec1955a6d2c4b0ce8f651885d77_1305855806.jpg",
		   AlbumId = 10,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Lệ Quyên"
	   },
	   new Track
	   {

		   TrackName = "Sầu tím thiệp hồng",
		   Duration = "04:48",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW66WE08?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/6/9/69e96a1693d6c8669f195b0f60376e7e_1367125585.jpg",
		   AlbumId = 11,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Đan Nguyên"
	   },
	   new Track
	   {

		   TrackName = "Đập vỡ cây đàn",
		   Duration = "05:05",
		   TrackLink = "https://zingmp3.vn/embed/song/ZWZBA0E7?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/6/9/69e96a1693d6c8669f195b0f60376e7e_1367125585.jpg",
		   AlbumId = 11,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Đan Nguyên"
	   },
	   new Track
	   {

		   TrackName = "Căn nhà màu tím",
		   Duration = "06:07",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW9ACWB8?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/4/d/4d00ecc3e7cbb8d5c2c211b0d826da5e_1286617072.jpg",
		   AlbumId = 11,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Đan Nguyên"
	   },
	   new Track
	   {

		   TrackName = "Chuyện tình không dĩ vãng ",
		   Duration = "06:16",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW67AADE?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/7/0/7014824a73ba9e48258e1fdd40c56fdc_1376293810.jpg",
		   AlbumId = 11,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Đan Nguyên"
	   },
	   new Track
	   {

		   TrackName = "Về đâu mái tóc người thương",
		   Duration = "04:18",
		   TrackLink = "https://zingmp3.vn/embed/song/ZW7I9WD0?",
		   UrlImg = "https://photo-resize-zmp3.zadn.vn/w94_r1x1_jpeg/covers/8/0/8016166bb1d434a6266b97eeb5433759_1334483423.jpg",
		   AlbumId = 11,
		   Genre = "Nhạc trữ tình",
		   ArtistName = "Đan Nguyên"
	   }
					);
				context.SaveChanges();
			}
			if (!context.Artists.Any())
			{
				context.Artists.AddRange(
					new Artist
					{
						ArtistName = "Hiền Hồ",
						Achievement = "Năm 2015 Hiền Hồ tham gia cuộc thi “Tiếng hát truyền hình” và “Nhân tố bí ẩn” vào năm 2016. Sau đó, cô nộp hồ sơ để vào học tại Nhạc viện Thành phố Hồ Chí Minh.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/c/0/3/f/c03f60341b00fdc0492dc0469020fcf9.jpg"
					},
					new Artist
					{

						ArtistName = "Min",
						Achievement = "Với giọng hát tình cảm ngọt ngào và cá tính, có thể nói rằng, Min như một cơn gió lạ, một hình tượng mới của giới nghệ thuật Việt Nam, đang từng bước khẳng định được chính mình với sự ủng hộ của thế hệ trẻ.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/a/a/d/c/aadcceb29e4a5c41fc3963acbde4bd0a.jpg"
					},
					new Artist
					{

						ArtistName = "Mr Siro",
						Achievement = "Là một nhạc sỹ có khả năng tự trình bày những ca khúc do chính anh sáng tác được khán giả đặc biệt yêu thích.Năm 2013, anh đạt nhiều giải thưởng quan trọng do Làn Sóng Xanh và Zing Music Award trao giúp con đường âm nhạc của ngày ngày một rộng mở hơn.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/e/1/1/2/e1120261421cfec7513423222b0ca94c.jpg"
					},
					new Artist
					{

						ArtistName = "Phúc Du",
						Achievement = "ERIK tham gia Giọng Hát Việt Nhí năm 2013 và dừng lại ở vị trí top 15.Năm 2014,anh tham gia cuộc thi của St.319 Entertainment và trở thành thực tập sinh.Năm 2016,ERIK debut với ca khúc Pop ballad Sau Tất Cả.Ca khúc nhanh chóng trở thành cơn sốt đối với giới trẻ.",
						ImgUrl = "https://photo-zmp3.zadn.vn/thumb/240_240/avatars/7/c/5/a/7c5a9d0ec012cb842476b83dbbc96e84.jpg"
					},
					new Artist
					{

						ArtistName = "BINZ",
						Achievement = "Tham gia cộng đồng underground Việt từ năm 2008, Binz đã từng là artist của một số diễn đàn rap như Midsiderap, GVR. Được biết tới rộng rãi hơn trong năm 2010 với mixtape ”M-da Legend” & những sản phẩm đáng chú ý kết hợp với rapper Cá Chép của Vietdreamerz",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/4/8/9/1/4891c7eef87e3ac85a50a2fba2674f5a.jpg"
					},
					new Artist
					{

						ArtistName = "BLACKPINK",
						Achievement = "Vào ngày 29/06/2016, YG Entertainment đã chính thức tiết lộ girlgroup mới của họ sẽ chỉ gồm bốn thành viên đã công bố từ trước, đồng thời nhóm sẽ có tên là Black Pink.Đại diện YG Entertainment cho biết: Ý nghĩa của tên gọi Black Pink là để phản bác lại cách nhìn nhận phổ biến về màu hồng.Hồng thường được sử dụng để thể hiện vẻ xinh đẹp nhưng BLACKPINK mang ý nghĩa 'Xinh đẹp không phải là tất cả'.Nó còn mang nghĩa biểu tượng rằng họ là một nhóm không chỉ sở hữu ngoại hình xinh đẹp mà còn cực kỳ tài năng và cá tính",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/f/1/1/1/f1113df32e09c1c5c6fe7069b0107c13.jpg"
					},
					new Artist
					{

						ArtistName = "BIGBANG",
						Achievement = "Cuối năm 2009, Big Bang trở thành tên tuổi nghệ sĩ được tìm kiếm nhiều nhất tại Hàn Quốc. Họ cũng trở thành nhóm nhạc nước ngoài đầu tiên tại Nhật Bản nhận được giải thưởng của Truyền hình cáp Nhật Bản với hạng mục Nghệ sĩ mới.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w360_r1x1_jpeg/avatars/e/a/ea507573ba1b7bfea6bbd715e4aa4c10_1481549701.jpg"
					},
					new Artist
					{

						ArtistName = "Alan Walker",
						Achievement = "Chàng trai Na Uy 18 tuổi bất ngờ được cả thế giới biết đến sau khi một trong trong những ca khúc đầu tay trở thành hiện tượng EDM toàn cầu.Trả lời phỏng vấn Mashable,nghệ sĩ trẻ không giấu khỏi tự hào khi Faded bất ngờ trở thành hiện tượng EDM tại Na Uy năm nay.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/c/0/c0158a5d0afdbb8b3d177162b9328a7c_1452770729.jpg"
					},
					new Artist
					{

						ArtistName = "DEAMN",
						Achievement = "Chàng trai Na Uy 18 tuổi bất ngờ được cả thế giới biết đến sau khi một trong trong những ca khúc đầu tay trở thành hiện tượng EDM toàn cầu.Trả lời phỏng vấn Mashable,nghệ sĩ trẻ không giấu khỏi tự hào khi Faded bất ngờ trở thành hiện tượng EDM tại Na Uy năm nay.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/c/0/c0158a5d0afdbb8b3d177162b9328a7c_1452770729.jpg"
					},
					new Artist
					{

						ArtistName = "Đan Lê",
						Achievement = "Đan Lê sinh năm 1983, từng là MC của chương trình Dự báo thời tiết Đài truyền hình Việt Nam.Cô tham gia đóng phim nhựa Em muốn làm người nổi tiếng và phim truyền hình Con đường sáng, nhận được nhiều sự yêu mến của khán giả.",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w360_r1x1_jpeg/avatars/4/e/4e2b0ef28ab651d398a1883c71dbfaf4_1371045341.jpg"
					},
					new Artist
					{

						ArtistName = "Quang Lê",
						Achievement = "Quang Lê hoạt động ca hát ở các sân khấu hải ngoại, anh tạo nên ấn tượng sâu sắc với khán giả qua dáng vẻ thư sinh cùng giọng hát trầm ấm và giàu tình cảm đậm chất Huế. Anh liên tiếp được trung tâm phát hành liên tiếp các album và đều tạo được tiếng vang lớn. ",
						ImgUrl = "https://photo-resize-zmp3.zadn.vn/w240_r1x1_jpeg/avatars/c/4/6/8/c468cef964a975378aadf1db950f2f9d.jpg"
					}
					);
				context.SaveChanges();
			}
			if (!context.ArtistTracks.Any())
			{
				context.ArtistTracks.AddRange(
					new ArtistTrack
					{
						ArtistId = 1,
						TrackId = 6
					},
				   new ArtistTrack
				   {
					   ArtistId = 1,
					   TrackId = 7

				   },
				   new ArtistTrack
				   {
					   ArtistId = 1,
					   TrackId = 8

				   },
				   new ArtistTrack
				   {
					   ArtistId = 1,
					   TrackId = 9

				   },
				   new ArtistTrack
				   {
					   ArtistId = 1,
					   TrackId = 10

				   },
				   new ArtistTrack
				   {
					   ArtistId = 2,
					   TrackId = 1

				   },
				   new ArtistTrack
				   {
					   ArtistId = 2,
					   TrackId = 2

				   },
				   new ArtistTrack
				   {
					   ArtistId = 2,
					   TrackId = 3

				   },
				   new ArtistTrack
				   {
					   ArtistId = 2,
					   TrackId = 4

				   },
				   new ArtistTrack
				   {
					   ArtistId = 2,
					   TrackId = 5

				   },
				   new ArtistTrack
				   {
					   ArtistId = 3,
					   TrackId = 11

				   },
				   new ArtistTrack
				   {
					   ArtistId = 3,
					   TrackId = 12

				   },
				   new ArtistTrack
				   {
					   ArtistId = 3,
					   TrackId = 13

				   },
				   new ArtistTrack
				   {
					   ArtistId = 3,
					   TrackId = 14

				   },
				   new ArtistTrack
				   {
					   ArtistId = 3,
					   TrackId = 15

				   },
				   new ArtistTrack
				   {
					   ArtistId = 4,
					   TrackId = 21

				   },
				   new ArtistTrack
				   {
					   ArtistId = 4,
					   TrackId = 22

				   },
				   new ArtistTrack
				   {
					   ArtistId = 4,
					   TrackId = 23

				   },
				   new ArtistTrack
				   {
					   ArtistId = 4,
					   TrackId = 24

				   },
				   new ArtistTrack
				   {
					   ArtistId = 4,
					   TrackId = 25

				   },
				   new ArtistTrack
				   {
					   ArtistId = 5,
					   TrackId = 16

				   },
				   new ArtistTrack
				   {
					   ArtistId = 5,
					   TrackId = 17

				   },
				   new ArtistTrack
				   {
					   ArtistId = 5,
					   TrackId = 18

				   },
				   new ArtistTrack
				   {
					   ArtistId = 5,
					   TrackId = 19

				   },
				   new ArtistTrack
				   {
					   ArtistId = 5,
					   TrackId = 20

				   },
				   new ArtistTrack
				   {
					   ArtistId = 6,
					   TrackId = 26

				   },
				   new ArtistTrack
				   {
					   ArtistId = 6,
					   TrackId = 27

				   },
				   new ArtistTrack
				   {
					   ArtistId = 6,
					   TrackId = 28

				   },
				   new ArtistTrack
				   {
					   ArtistId = 6,
					   TrackId = 29

				   },
				   new ArtistTrack
				   {
					   ArtistId = 6,
					   TrackId = 30

				   },
				   new ArtistTrack
				   {
					   ArtistId = 7,
					   TrackId = 31

				   },
				   new ArtistTrack
				   {
					   ArtistId = 7,
					   TrackId = 32

				   },
				   new ArtistTrack
				   {
					   ArtistId = 7,
					   TrackId = 33

				   },
				   new ArtistTrack
				   {
					   ArtistId = 7,
					   TrackId = 34

				   },
				   new ArtistTrack
				   {
					   ArtistId = 7,
					   TrackId = 35

				   },
				   new ArtistTrack
				   {
					   ArtistId = 8,
					   TrackId = 36

				   },
				   new ArtistTrack
				   {
					   ArtistId = 8,
					   TrackId = 37

				   },
				   new ArtistTrack
				   {
					   ArtistId = 8,
					   TrackId = 38

				   },
				   new ArtistTrack
				   {
					   ArtistId = 8,
					   TrackId = 39

				   },
				   new ArtistTrack
				   {
					   ArtistId = 8,
					   TrackId = 40

				   },
				   new ArtistTrack
				   {
					   ArtistId = 9,
					   TrackId = 41

				   },
				   new ArtistTrack
				   {
					   ArtistId = 9,
					   TrackId = 42

				   },
				   new ArtistTrack
				   {
					   ArtistId = 9,
					   TrackId = 43

				   },
				   new ArtistTrack
				   {
					   ArtistId = 9,
					   TrackId = 44

				   },
				   new ArtistTrack
				   {
					   ArtistId = 9,
					   TrackId = 45

				   },
				   new ArtistTrack
				   {
					   ArtistId = 10,
					   TrackId = 46

				   },
				   new ArtistTrack
				   {
					   ArtistId = 10,
					   TrackId = 47

				   },
				   new ArtistTrack
				   {
					   ArtistId = 10,
					   TrackId = 48

				   },
				   new ArtistTrack
				   {
					   ArtistId = 10,
					   TrackId = 49

				   },
				   new ArtistTrack
				   {
					   ArtistId = 10,
					   TrackId = 50

				   },
				   new ArtistTrack
				   {
					   ArtistId = 11,
					   TrackId = 51

				   },
				   new ArtistTrack
				   {
					   ArtistId = 11,
					   TrackId = 52

				   },
				   new ArtistTrack
				   {
					   ArtistId = 11,
					   TrackId = 53

				   },
				   new ArtistTrack
				   {
					   ArtistId = 11,
					   TrackId = 54

				   },
				   new ArtistTrack
				   {
					   ArtistId = 11,
					   TrackId = 55

				   }
				);
				context.SaveChanges();
			}

		}
	}
}