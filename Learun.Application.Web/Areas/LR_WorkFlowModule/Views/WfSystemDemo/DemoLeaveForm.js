/*
 * 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架(http://www.learun.cn)
 * Copyright (c) 2013-2020 上海力软信息技术有限公司
 * 创建人：力软-前端开发组
 * 日 期：2017.04.17
 * 描 述：请假单-用于工作流系统表单
 */
var keyValue = "";

// 设置权限
var setAuthorize;
// 设置表单数据
var setFormData;
// 验证数据是否填写完整
var validForm;
// 保存数据
var save;
var isUpdate = false;


var bootstrap = function ($, learun) {
    "use strict";
    
    // 设置权限
    setAuthorize = function (data) {
        $.each(data || {}, function (id, field) {
            if (field.isLook != 1) {// 如果没有查看权限就直接移除
                $('#' + field.fieldId).parent().remove();
            }
            else {
                if (field.isEdit != 1) {
                    $('#' + field.fieldId).attr('disabled', 'disabled');
                    if ($('#' + field.fieldId).hasClass('lrUploader-wrap')) {
                        $('#' + field.fieldId).css({ 'padding-right': '58px' });
                        $('#' + field.fieldId).find('.btn-success').remove();
                    }
                }
            }

        })
    };
    // 设置表单数据
    setFormData = function (processId, _fileInfoId, callback) {
        if (!!processId) {
            $.lrSetForm(top.$.rootUrl + '/LR_WorkFlowModule/WfSystemDemo/DemoLeaveGetFormData?processId=' + processId, function (data) {//
                if (!!data) {
                    isUpdate = true;
                    $('#form').lrSetFormData(data);
                }
                callback();
            });
        }
    };
    // 验证数据是否填写完整
    validForm = function () {
        if (!$('#form').lrValidform()) {
            return false;
        }
        return true;
    };
    // 保存调用函数
    save = function (processId, callBack, i) {
        var postData = $('#form').lrGetFormData(keyValue);
        if (isUpdate) {
            keyValue = processId;
        }
        else {
            postData.F_Id = processId;
        }
        $.lrSaveForm(top.$.rootUrl + '/LR_WorkFlowModule/WfSystemDemo/DemoLeaveSaveForm?keyValue=' + keyValue, postData, function (res) {
            // 保存成功后才回调
            if (!!callBack) {
                callBack(res, i);
            }
        });
    };
    // 获取表单数据
    keyValue = request('keyValue') || '';
    if (!!keyValue) {
        setFormData(keyValue);
    }
}