using UnityEngine;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace UnityEngineAssets.Unity {
	public static partial class Convert {
		// int..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 ToInt2 (this double2 f) => new int2((int)f.x, (int)f.y);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ToInt3 (this double2 f) => new int3((int)f.x, (int)f.y, 0);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ToInt4 (this double2 f) => new int4((int)f.x, (int)f.y, 0, 0);

		// uint..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint2 ToUint2 (this double2 f) => new uint2((uint)f.x, (uint)f.y);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 ToUint3 (this double2 f) => new uint3((uint)f.x, (uint)f.y, 0u);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 ToUint4 (this double2 f) => new uint4((uint)f.x, (uint)f.y, 0u, 0u);

		// bool..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 ToBool2 (this double2 f) => new bool2(f.x != 0, f.y != 0);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 ToBool3 (this double2 f) => new bool3(f.x != 0, f.y != 0, false);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 ToBool4 (this double2 f) => new bool4(f.x != 0, f.y != 0, false, false);

		// double..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 ToDouble3 (this double2 f) => new double3(f.x, f.y, 0d);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 ToDouble4 (this double2 f) => new double4(f.x, f.y, 0d, 0d);

		// float..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 ToFloat2 (this double2 f) => new float2((float)f.x, (float)f.y);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 ToFloat3 (this double2 f) => new float3((float)f.x, (float)f.y, 0f);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 ToFloat4 (this double2 f) => new float4((float)f.x, (float)f.y, 0f, 0f);

		// half..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half2 ToHalf2 (this double2 f) => new half2(new half(f.x), new half(f.y));

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half3 ToHalf3 (this double2 f) => new half3(new half(f.x), new half(f.y), half.zero);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static half4 ToHalf4 (this double2 f) => new half4(new half(f.x), new half(f.y), half.zero, half.zero);

		// Vector..
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ToVector2 (this double2 f) => new Vector2((float)f.x, (float)f.y);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ToVector3 (this double2 f) => new Vector3((float)f.x, (float)f.y, 0f);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ToVector4 (this double2 f) => new Vector4((float)f.x, (float)f.y, 0f, 0f);

		// Vector..Int
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int ToVector2Int (this double2 f) => new Vector2Int((int)f.x, (int)f.y);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int ToVector3Int (this double2 f) => new Vector3Int((int)f.x, (int)f.y, 0);
	}
}
