<template>
	<view class="wrap">
		<view class="top"></view>
		<view class="content">
			<view class="title u-text-center">欢迎登录</view>
			<input class="u-border-bottom u-margin-20" type="text" v-model="username" placeholder="请输入账号" /> 
			<input class="u-border-bottom u-margin-20" type="password" v-model="password" placeholder="请输入密码" /> 
			<button @tap="submit" :style="[inputStyle]" class="getCaptcha">登陆</button>

		</view>

	</view>
</template>

<script>
	export default {
		data() {
			return { 
				username: '',
				password: ''
			}
		},
		
		computed: {
			inputStyle() {
				let style = {};
				if (this.username && this.password) {
					style.color = "#fff";
					style.backgroundColor = this.$u.color['warning'];
				}
				return style;
			}
		},
		methods: {
			async submit() {
				 var data={Account:this.username,Password:this.password};
                //const res= await this.$u.api.login(data); 
				var paramedata={PageSize:11,IsGas:false};
				var aaaa= await this.$u.api.hisindex(paramedata);
				 
				uni.setStorageSync('username', this.username);
				var localStorageUser = uni.getStorageSync('username');
				this.$u.toast(localStorageUser + ',登陆成功');
				uni.reLaunch({
					url:'/pages/index/index'
				}) 
			}
		}
	};
</script>

<style lang="scss" scoped>
	.wrap {
		font-size: 28rpx;

		.content {
			width: 600rpx;
			margin: 80rpx auto 0;

			.title {
				font-size: 60rpx;
				font-weight: 500;
				margin-bottom: 100rpx;
			}

			input {
				text-align: left;
				margin-bottom: 10rpx;
				padding-bottom: 6rpx;
			}

			.tips {
				color: $u-type-info;
				margin-bottom: 60rpx;
				margin-top: 8rpx;
			}

			.getCaptcha {
				background-color: rgb(253, 243, 208);
				color: $u-tips-color;
				border: none;
				font-size: 30rpx;
				padding: 12rpx 0;

				&::after {
					border: none;
				}
			}  
		} 
	}
</style>
