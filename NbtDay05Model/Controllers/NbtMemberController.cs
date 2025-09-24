using Microsoft.AspNetCore.Mvc;
using NbtDay05Model.Models;
namespace NbtDay05Model.Controllers
{
    public class NbtMemberController : Controller
    {
        static List<NbtMember> members = new List<NbtMember>()
    {
    new NbtMember { MemberId = Guid.NewGuid().ToString(), UserName = "nbtruong", FullName = "Nguyen Ba Truong", Password = "123456", Email = "nguyenbatruong1301@gmail.com" },
    new NbtMember { MemberId = Guid.NewGuid().ToString(), UserName = "user01", FullName = "Nguyen Van A", Password = "111111", Email = "user01@gmail.com" },
    new NbtMember { MemberId = Guid.NewGuid().ToString(), UserName = "user02", FullName = "Tran Thi B", Password = "222222", Email = "user02@gmail.com" },
    new NbtMember { MemberId = Guid.NewGuid().ToString(), UserName = "user03", FullName = "Le Van C", Password = "333333", Email = "user03@gmail.com" },
    new NbtMember { MemberId = Guid.NewGuid().ToString(), UserName = "user04", FullName = "Pham Thi D", Password = "444444", Email = "user04@gmail.com" }
    };

        public IActionResult Index()
        {
            //scaffolding
            return View(members);
        }
        // Get NbtCreate
        [HttpGet]
        public IActionResult NbtCreate()
        {
            return View();
        }
        // Post NbtCreate
        [HttpPost]
        public IActionResult NbtCreate(NbtMember model)
        {
            var member = new NbtMember();
            member.MemberId = Guid.NewGuid().ToString();
            member.FullName = model.FullName;
            member.UserName = model.UserName;
            member.Password = model.Password;
            member.Email = model.Email;
            return RedirectToAction("Index");

        }
        // Get NbtEdit
        [HttpGet]
        public IActionResult NbtEdit(string id)
        {
            var model =members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult NbtEdit(string id, NbtMember model)
        {
             members.Where(x => x.MemberId == id).FirstOrDefault().FullName = model.FullName;
             members.Where(x => x.MemberId == id).FirstOrDefault().UserName = model.UserName;
             members.Where(x => x.MemberId == id).FirstOrDefault().Password = model.Password;
             members.Where(x => x.MemberId == id).FirstOrDefault().Email = model.Email;


            return RedirectToAction("Index");
        }
        // Details
        [HttpGet]
        public IActionResult NbtDetails(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        //NbtDelete
        [HttpGet]
        public IActionResult NbtDelete(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View();
        
        }
        [HttpPost]
        public IActionResult NbtDelete(string id, NbtMember model)
        {
            var member = members.FirstOrDefault(x => x.MemberId == id);
            if (member != null)
            {
                members.Remove(member);
            }
            return RedirectToAction("Index");
        }



        public IActionResult NbtGetMember()
        {
            var NbtMember = new NbtMember();
            NbtMember.MemberId = Guid.NewGuid().ToString();
            NbtMember.UserName = "nbtruong";
            NbtMember.FullName = "Nguyen Ba Truong";
            NbtMember.Password = "123456";
            NbtMember.Email = "nguyenbatruong1301@gmail.com";

            ViewBag.NbtMember = NbtMember;
            return View();
        }

        public IActionResult NbtGetMembers()
        {
            return View(members);
        }
    }
}
