using Sandbox;

namespace BugGame
{
    public class BugGame : Game
    {
        [ServerCmd( "sv_code_gen_crash" )]
        public static void CodeGenCrash() => CrashTime();
		[ClientCmd( "cl_code_gen_crash" )]
		public static void ClientCodeGenCrash() => CrashTime();

        public static void CrashTime() { }
    }
}
