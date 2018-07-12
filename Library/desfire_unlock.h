#pragma unmanaged
/* http://blog.danggun.net/16 */
/* http://blog.danggun.net/799 */

extern "C" __declspec(dllexport) void triple_des_cbc_decrypt(char * input_data, char * result, int size, char * init_vector);
extern "C" __declspec(dllexport) void triple_des_cbc_encrypt(char * input_data, char * result, int size, char * init_vector);
