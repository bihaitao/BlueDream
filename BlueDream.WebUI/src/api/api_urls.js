/*
项目中所有请求地址，无论是后台地址还是外部地址
统一存放于此文件中，禁止存放在其他文件和代码中
*/

//基础地址
let api_base = process.env.VUE_APP_BASE_URL; 

const api_urls = {
	//登录接口地
	system_login : api_base+'/system/login',
	//之前的接口 需要修改
	permission:api_base+'/permission'
}

//导出请求
export default api_urls