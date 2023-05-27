//定义接口----
import axios from '@/utils/request'
//导入api地址
import api_urls from '@/api/api_urls'
//环境变量


//定义方法
/* 
  登录
  { user, pwd}
  */
export function login(params) {
    return axios.post(api_urls.system_login, params);
}
/* 
    用户权限--返回导航内容
    params={token:''}
  */
export function permission(params) {
    return axios.get(api_urls.permission, {
        params,
    });
}


