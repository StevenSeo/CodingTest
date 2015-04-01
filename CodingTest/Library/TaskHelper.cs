using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brass9.Threading.TPL
{
	public static class TaskHelper
	{
		/// <summary>
		/// Runs a TPL Task fire-and-forget style, the right way - in the background, separate from the current thread,
		/// with no risk of it trying to rejoin the current thread.
		/// 
		/// Usage:
		/// 
		/// TaskHelper.RunBg(() => methodAsync(args));
		/// 
		/// or
		/// 
		/// TaskHelper.RunBg(async () => {
		///		await methodAsync1();
		///		await methodAsync2();
		/// });
		/// </summary>
		/// <param name="fn">Func Task or if you like, an async Action that contains an await (these are technically
		/// Func Tasks underneath the hood).</Task></param>
		public static void RunBg(Func<Task> fn)
		{
			#pragma warning disable 4014 // Fire and forget.
			Task.Run(fn).ConfigureAwait(false);
		}
	}
}
