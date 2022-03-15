<template>
	<view>
      
	     <u-subsection :list="list" :current="0"></u-subsection>
		 <myarcbar :testdata="mytestdata"></myarcbar>
		 <view class="myouttext">
			<view class="mytext"><view class="mytext_inner">TOC</view><u-tag text="20ml/g"  plainFill  plain   type="success"></u-tag></view>
			<view class="mytext"><view class="mytext_inner">氨氮</view><u-tag text="20ml/g"  plainFill   type="warning"></u-tag></view>
			<view class="mytext"><view class="mytext_inner">总磷</view><u-tag text="20ml/g" plainFill     type="warning"></u-tag></view>
			<view class="mytext"><view class="mytext_inner">PH</view><u-tag text="20ml/g"  plainFill   type="success"></u-tag></view>
			<view class="mytext"><view class="mytext_inner">流量</view><u-tag text="20ml/g"   plainFill   type="success"></u-tag></view>
		 </view>
		
		<u-gap height="10" bgColor="#bbb"></u-gap>
		<view class="u-padding-20 mytitle">实时折线图</view>
		<u-gap height="3" bgColor="#bbb"></u-gap>
		<myarea :testdata="mytestdata"></myarea>
		
		<u-gap height="10" bgColor="#bbb"></u-gap>
	    <view class="u-padding-20 mytitle">实时监测数据</view>
		<u-gap height="3" bgColor="#bbb"></u-gap> 
		<mytable></mytable>
		 
       
	</view>
</template>

<script>
	export default {
		data() {
			return {
				title: 'Hello',
				chartData: {
					categories: [],
					series: [],
				},
				mytestdata: {
					title: '测试1'
				},
				opts: {},
				list: ['水质','气体'],
				// 或者如下，也可以配置keyName参数修改对象键名
				// list: [{name: '未付款'}, {name: '待评价'}, {name: '已付款'}],
				current: 0,

			}
		},
		onLoad() {

		},
		onReady() {
			//调用绘制方法
			this.mytestdata = {
				title: 'ceshi'
			}

		},

		methods: {
			click(item) {
				console.log('item', item);
			}

		},

		mounted() {

		}
	}
</script>

<style lang="scss" scoped>
	@mixin flexCenter {
		display: flex;
		justify-content: center;
		align-items: center;
	}
	.myouttext{
		padding: 10rpx;
		text-align: center;
	}    
	.mytext {
		display: inline-block;
		padding: 10rpx;
	}
	.mytext_inner{
		padding-bottom: 5rpx;
	}
		.mytag {
		padding: 0 60rpx 0 60rpx;
	}
    .mytitle{
		text-align: center;
	}
	.mytab_inner {
		margin: 0 10rpx 10rpx 0;
	}

	.content {
		width: 100%;
		height: 100%;
		background: #fff;

		.warnInfo {
			width: 100%;
			height: 300upx;
			background: #132040;

			font-size: 30upx;
			color: #fff;

			.warn_title {
				width: 100%;
				height: 60upx;
				line-height: 60upx;
				text-align: left;
				background: #182951;
				padding: 0 40upx;
				box-sizing: border-box;
			}

			.warn_echart {
				width: 100%;
				padding: 0 40upx;
				box-sizing: border-box;
				height: calc(100% - 60upx) !important;
				color: #fff;

				.charts_box {
					width: 100%;
					height: 100%;
				}
			}
		}
	}
</style>
