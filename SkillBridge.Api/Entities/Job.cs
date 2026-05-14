using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using Microsoft.Net.Http.Headers;
using SkillBridge.Api.Entities;

namespace SkillBridge.Api.Entities
{
	public class Job
{
	[Required,Key]
	public int Id {get;set;}
	public string Title {get;set;}
[Required]
	public string Description {get;set;}
	[Required]

	public string Company {get;set;}
	[Required]

	public string Location {get;set;}
	[Required]

	public string JobType {get;set;}
	[Required]


	public decimal MinimumSalary {get;set;}
	[Required]

	public decimal MaximumSalary {get;set;}
	[Required]

	public DateTime PostedDate {get;set;}
	[Required]

	public DateTime? DeadLineDate {get;set;}
	public bool isActive {get;set;}
[Required]

	public User PostedBY {get;set;}
	public int PostedBYID {get;set;}

}
}