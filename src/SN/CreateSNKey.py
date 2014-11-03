import subprocess, os, argparse, os.path

# Need to wrap this around " due to spaces in the path
sn = '"' + "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v8.0A\\bin\\NETFX 4.0 Tools\\x64\\sn.exe" + '"'

parser = argparse.ArgumentParser(description="Creates a Visual Studio \
                                 strong name key pair based on the RSA key size and hash algorithm specified")

parser.add_argument("RSA", choices=["1024", "2048", "4096", "8192"],
                    help="Size of RSA keys")
parser.add_argument("Hash", choices=["sha1", "sha256", "sha384", "sha512"],
                    help="Hash algorithm to use")
args = parser.parse_args()

privKeyFile="StripeNet.snk"
pubKeyFile="StripeNetPublic.snk"

if (os.path.isfile(privKeyFile) or os.path.isfile(pubKeyFile)):
	print()
	print("Key files already exist! Skipping overwriting")
	print("If sure, delete manually and re-run script")
	exit()

try:
    os.remove(privKeyFile)
    os.remove(pubKeyFile)
except IOError as e:	
    # print(e)
    pass # raise

# Create keypair    
return_code = subprocess.call(sn + " -k " + args.RSA + " " + privKeyFile, shell=True)

# Extract public key and use hash
if return_code==0:
    return_code = subprocess.call(sn + " -p " + privKeyFile + " " + pubKeyFile + " " + args.Hash, shell=True)

print("===================================================")	
print("To see the public key for usage, try this")
print()
print("sn -Tp Assembly.dll")
print()
print("NOTE: You MUST run it on the actual DLL/EXE and NOT")
print("      directly on the keys (results ARE different)")
print("===================================================")
exit(return_code)
