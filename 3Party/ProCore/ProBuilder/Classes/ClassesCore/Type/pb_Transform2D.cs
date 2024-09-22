using UnityEngine;
using ProBuilder2.Math;

namespace ProBuilder2.Common
{	
	/**
	 * A Transform class limited to 2D
	 */
	public class pb_Transform2D
	{
#region Members

		public Vector2 	position;	///< Position in 2D space.
		public float 	rotation;	///< Rotation in degrees.
		public Vector2 	scale;		///< Scale in 2D space.
#endregion

#region Constructor

		public pb_Transform2D(Vector2 position, float rotation, Vector2 scale)
		{
			this.position 	= position;
			this.rotation 	= rotation;
			this.scale 		= scale;
		}
#endregion

#region Instance Methods

		public Vector2 TransformPoint(Vector2 p)
		{
			p += position;
			p.RotateAroundPoint(p, rotation);
			p.ScaleAroundPoint(p, scale);
			return p;
		}
#endregion

#region Override

		public override string ToString()
		{
			return "T: " + position + "\nR: " + rotation + pb_Constant.DEGREE_SYMBOL + "\nS: " + scale;
		}
#endregion
	}
}